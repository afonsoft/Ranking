using Afonsoft.Ranking.Editions;
using Afonsoft.Ranking.Editions.Dto;
using Afonsoft.Ranking.MultiTenancy.Payments;
using Afonsoft.Ranking.Security;
using Afonsoft.Ranking.MultiTenancy.Payments.Dto;

namespace Afonsoft.Ranking.Web.Models.TenantRegistration
{
    public class TenantRegisterViewModel
    {
        public PasswordComplexitySetting PasswordComplexitySetting { get; set; }

        public int? EditionId { get; set; }

        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }
    }
}
