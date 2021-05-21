using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Afonsoft.Ranking.EntityFrameworkCore
{
    public static class RankingDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<RankingDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<RankingDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}