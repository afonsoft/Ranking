using System.Collections.Generic;
using Afonsoft.Ranking.Editions;
using Afonsoft.Ranking.Editions.Dto;
using Afonsoft.Ranking.MultiTenancy.Payments;
using Afonsoft.Ranking.MultiTenancy.Payments.Dto;

namespace Afonsoft.Ranking.Web.Models.Payment
{
    public class BuyEditionViewModel
    {
        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public decimal? AdditionalPrice { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}
