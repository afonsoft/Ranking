using Abp.Dependency;
using Abp.Reflection.Extensions;
using Microsoft.Extensions.Configuration;
using Afonsoft.Ranking.Configuration;

namespace Afonsoft.Ranking.Test.Base
{
    public class TestAppConfigurationAccessor : IAppConfigurationAccessor, ISingletonDependency
    {
        public IConfigurationRoot Configuration { get; }

        public TestAppConfigurationAccessor()
        {
            Configuration = AppConfigurations.Get(
                typeof(RankingTestBaseModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }
    }
}
