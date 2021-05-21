using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Afonsoft.Ranking.Authorization;

namespace Afonsoft.Ranking
{
    /// <summary>
    /// Application layer module of the application.
    /// </summary>
    [DependsOn(
        typeof(RankingApplicationSharedModule),
        typeof(RankingCoreModule)
        )]
    public class RankingApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Adding authorization providers
            Configuration.Authorization.Providers.Add<AppAuthorizationProvider>();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(RankingApplicationModule).GetAssembly());
        }
    }
}