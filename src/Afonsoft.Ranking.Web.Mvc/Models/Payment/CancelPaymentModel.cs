﻿using Afonsoft.Ranking.MultiTenancy.Payments;

namespace Afonsoft.Ranking.Web.Models.Payment
{
    public class CancelPaymentModel
    {
        public string PaymentId { get; set; }

        public SubscriptionPaymentGatewayType Gateway { get; set; }
    }
}