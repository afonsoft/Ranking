using System.Collections.Generic;

namespace Afonsoft.Ranking.MultiTenancy.Payments
{
    public interface IPaymentGatewayStore
    {
        List<PaymentGatewayModel> GetActiveGateways();
    }
}
