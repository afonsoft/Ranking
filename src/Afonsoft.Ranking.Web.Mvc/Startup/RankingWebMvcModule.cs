using Abp.AspNetZeroCore;
using Abp.Configuration.Startup;
using Abp.Dependency;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Threading.BackgroundWorkers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Afonsoft.Ranking.Auditing;
using Afonsoft.Ranking.Configuration;
using Afonsoft.Ranking.EntityFrameworkCore;
using Afonsoft.Ranking.MultiTenancy;
using Afonsoft.Ranking.Web.Areas.App.Startup;

namespace Afonsoft.Ranking.Web.Startup
{
    [DependsOn(
        typeof(RankingWebCoreModule)
    )]
    public class RankingWebMvcModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public RankingWebMvcModule(IWebHostEnvironment env)
        {
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Modules.AbpWebCommon().MultiTenancy.DomainFormat = _appConfiguration["App:WebSiteRootAddress"] ?? "https://localhost:44302/";
            Configuration.Modules.AspNetZero().LicenseCode = "AFONSOFT";

            Configuration.Modules.AbpWebCommon().SendAllExceptionsToClients = true;

            Configuration.Auditing.IsEnabledForAnonymousUsers = false;
            Configuration.Auditing.IsEnabled = true;
            Configuration.EntityHistory.IsEnabled = true;
            Configuration.EntityHistory.IsEnabledForAnonymousUsers = false;

            Configuration.Navigation.Providers.Add<AppNavigationProvider>();

            IocManager.Register<DashboardViewConfiguration>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(RankingWebMvcModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!IocManager.Resolve<IMultiTenancyConfig>().IsEnabled)
            {
                return;
            }

            using (var scope = IocManager.CreateScope())
            {
                if (!scope.Resolve<DatabaseCheckHelper>().Exist(_appConfiguration["ConnectionStrings:Default"]))
                {
                    return;
                }
            }

            var workManager = IocManager.Resolve<IBackgroundWorkerManager>();
            if (IocManager.Resolve<IMultiTenancyConfig>().IsEnabled)
            {
                workManager.Add(IocManager.Resolve<SubscriptionExpirationCheckWorker>());
                workManager.Add(IocManager.Resolve<SubscriptionExpireEmailNotifierWorker>());
            }

            if (Configuration.Auditing.IsEnabled)
            {
                workManager.Add(IocManager.Resolve<ExpiredAuditLogDeleterWorker>());
            }
        }
    }
}