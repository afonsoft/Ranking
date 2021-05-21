using Abp.Events.Bus;

namespace Afonsoft.Ranking.MultiTenancy
{
    public class RecurringPaymentsEnabledEventData : EventData
    {
        public int TenantId { get; set; }
    }
}