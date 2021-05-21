using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Afonsoft.Ranking
{
    public class RankingCoreSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(RankingCoreSharedModule).GetAssembly());
        }
    }
}