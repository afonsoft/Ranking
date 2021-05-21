using Abp.Events.Bus.Handlers;

namespace Afonsoft.Ranking.MultiTenancy.Payments
{
    public interface ISupportsRecurringPayments : 
        IEventHandler<RecurringPaymentsDisabledEventData>, 
        IEventHandler<RecurringPaymentsEnabledEventData>,
        IEventHandler<TenantEditionChangedEventData>
    {

    }
}
