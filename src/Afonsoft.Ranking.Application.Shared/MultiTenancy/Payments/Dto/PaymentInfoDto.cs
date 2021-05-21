using Afonsoft.Ranking.Editions.Dto;

namespace Afonsoft.Ranking.MultiTenancy.Payments.Dto
{
    public class PaymentInfoDto
    {
        public EditionSelectDto Edition { get; set; }

        public decimal AdditionalPrice { get; set; }

        public bool IsLessThanMinimumUpgradePaymentAmount()
        {
            return AdditionalPrice < RankingConsts.MinimumUpgradePaymentAmount;
        }
    }
}
