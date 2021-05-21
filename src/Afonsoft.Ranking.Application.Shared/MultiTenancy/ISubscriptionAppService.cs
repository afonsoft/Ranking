using System.Threading.Tasks;
using Abp.Application.Services;

namespace Afonsoft.Ranking.MultiTenancy
{
    public interface ISubscriptionAppService : IApplicationService
    {
        Task DisableRecurringPayments();

        Task EnableRecurringPayments();
    }
}
