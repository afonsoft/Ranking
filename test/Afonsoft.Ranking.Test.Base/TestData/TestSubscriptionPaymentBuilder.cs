using System.Linq;
using Afonsoft.Ranking.Editions;
using Afonsoft.Ranking.EntityFrameworkCore;
using Afonsoft.Ranking.MultiTenancy.Payments;

namespace Afonsoft.Ranking.Test.Base.TestData
{
    public class TestSubscriptionPaymentBuilder
    {
        private readonly RankingDbContext _context;
        private readonly int _tenantId;

        public TestSubscriptionPaymentBuilder(RankingDbContext context, int tenantId)
        {
            _context = context;
            _tenantId = tenantId;
        }

        public void Create()
        {
            CreatePayments();
        }

        private void CreatePayments()
        {
            var defaultEdition = _context.Editions.First(e => e.Name == EditionManager.DefaultEditionName);

            CreatePayment(1, defaultEdition.Id, _tenantId, 1, "147741");
            CreatePayment(19, defaultEdition.Id, _tenantId, 30, "1477419");
        }

        private void CreatePayment(decimal amount, int editionId, int tenantId, int dayCount, string paymentId)
        {
            _context.SubscriptionPayments.Add(new SubscriptionPayment
            {
                Amount = amount,
                EditionId = editionId,
                TenantId = tenantId,
                DayCount = dayCount,
                ExternalPaymentId = paymentId
            });
        }
    }

}
