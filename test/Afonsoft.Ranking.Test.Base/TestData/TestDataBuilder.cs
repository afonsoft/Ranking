using Afonsoft.Ranking.EntityFrameworkCore;

namespace Afonsoft.Ranking.Test.Base.TestData
{
    public class TestDataBuilder
    {
        private readonly RankingDbContext _context;
        private readonly int _tenantId;

        public TestDataBuilder(RankingDbContext context, int tenantId)
        {
            _context = context;
            _tenantId = tenantId;
        }

        public void Create()
        {
            new TestOrganizationUnitsBuilder(_context, _tenantId).Create();
            new TestSubscriptionPaymentBuilder(_context, _tenantId).Create();
            new TestEditionsBuilder(_context).Create();

            _context.SaveChanges();
        }
    }
}
