using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Afonsoft.Ranking
{
    [DependsOn(typeof(RankingCoreSharedModule))]
    public class RankingApplicationSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(RankingApplicationSharedModule).GetAssembly());
        }
    }
}