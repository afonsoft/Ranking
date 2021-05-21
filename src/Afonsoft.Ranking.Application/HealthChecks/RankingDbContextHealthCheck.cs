using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Afonsoft.Ranking.EntityFrameworkCore;

namespace Afonsoft.Ranking.HealthChecks
{
    public class RankingDbContextHealthCheck : IHealthCheck
    {
        private readonly DatabaseCheckHelper _checkHelper;

        public RankingDbContextHealthCheck(DatabaseCheckHelper checkHelper)
        {
            _checkHelper = checkHelper;
        }

        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = new CancellationToken())
        {
            if (_checkHelper.Exist("db"))
            {
                return Task.FromResult(HealthCheckResult.Healthy("RankingDbContext connected to database."));
            }

            return Task.FromResult(HealthCheckResult.Unhealthy("RankingDbContext could not connect to database"));
        }
    }
}
