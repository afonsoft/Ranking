using System.Threading.Tasks;
using Abp.Application.Services;
using Afonsoft.Ranking.MultiTenancy.Payments.Dto;
using Afonsoft.Ranking.MultiTenancy.Payments.Stripe.Dto;

namespace Afonsoft.Ranking.MultiTenancy.Payments.Stripe
{
    public interface IStripePaymentAppService : IApplicationService
    {
        Task ConfirmPayment(StripeConfirmPaymentInput input);

        StripeConfigurationDto GetConfiguration();

        Task<SubscriptionPaymentDto> GetPaymentAsync(StripeGetPaymentInput input);

        Task<string> CreatePaymentSession(StripeCreatePaymentSessionInput input);
    }
}