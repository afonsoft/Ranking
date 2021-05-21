using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Afonsoft.Ranking
{
    public class RankingClientModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(RankingClientModule).GetAssembly());
        }
    }
}
