using Microsoft.Extensions.Configuration;

namespace Afonsoft.Ranking.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
