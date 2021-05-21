using System.Collections.Generic;
using Afonsoft.Ranking.Editions.Dto;
using Afonsoft.Ranking.MultiTenancy.Payments;

namespace Afonsoft.Ranking.Web.Models.Payment
{
    public class ExtendEditionViewModel
    {
        public EditionSelectDto Edition { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}