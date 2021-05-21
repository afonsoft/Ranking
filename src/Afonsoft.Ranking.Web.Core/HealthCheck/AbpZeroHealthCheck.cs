using Microsoft.Extensions.DependencyInjection;
using Afonsoft.Ranking.HealthChecks;

namespace Afonsoft.Ranking.Web.HealthCheck
{
    public static class AbpZeroHealthCheck
    {
        public static IHealthChecksBuilder AddAbpZeroHealthCheck(this IServiceCollection services)
        {
            var builder = services.AddHealthChecks();
            builder.AddCheck<RankingDbContextHealthCheck>("Database Connection");
            builder.AddCheck<RankingDbContextUsersHealthCheck>("Database Connection with user check");
            builder.AddCheck<CacheHealthCheck>("Cache");

            // add your custom health checks here
            // builder.AddCheck<MyCustomHealthCheck>("my health check");

            return builder;
        }
    }
}
