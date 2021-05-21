using Afonsoft.Ranking.EntityFrameworkCore;

namespace Afonsoft.Ranking.Migrations.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly RankingDbContext _context;

        public InitialHostDbBuilder(RankingDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
