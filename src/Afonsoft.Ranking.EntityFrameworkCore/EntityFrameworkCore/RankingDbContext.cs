using Abp.IdentityServer4vNext;
using Abp.Zero.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Afonsoft.Ranking.Authorization.Delegation;
using Afonsoft.Ranking.Authorization.Roles;
using Afonsoft.Ranking.Authorization.Users;
using Afonsoft.Ranking.Chat;
using Afonsoft.Ranking.Editions;
using Afonsoft.Ranking.Friendships;
using Afonsoft.Ranking.MultiTenancy;
using Afonsoft.Ranking.MultiTenancy.Accounting;
using Afonsoft.Ranking.MultiTenancy.Payments;
using Afonsoft.Ranking.Storage;
using Afonsoft.Ranking.Championships;

using Microsoft.Extensions.Configuration;
using System.Linq;

namespace Afonsoft.Ranking.EntityFrameworkCore
{
    public class RankingDbContext : AbpZeroDbContext<Tenant, Role, User, RankingDbContext>, IAbpPersistedGrantDbContext
    {
        /* Define an IDbSet for each entity of the application */

        public virtual DbSet<BinaryObject> BinaryObjects { get; set; }

        public virtual DbSet<Friendship> Friendships { get; set; }

        public virtual DbSet<ChatMessage> ChatMessages { get; set; }

        public virtual DbSet<SubscribableEdition> SubscribableEditions { get; set; }

        public virtual DbSet<SubscriptionPayment> SubscriptionPayments { get; set; }

        public virtual DbSet<Invoice> Invoices { get; set; }

        public virtual DbSet<PersistedGrantEntity> PersistedGrants { get; set; }

        public virtual DbSet<SubscriptionPaymentExtensionData> SubscriptionPaymentExtensionDatas { get; set; }

        public virtual DbSet<UserDelegation> UserDelegations { get; set; }

        public virtual DbSet<Championship> Championships { get; set; }

        public virtual DbSet<CalendarChampionship> CalendarChampionships { get; set; }

        public virtual DbSet<TeamChampionship> TeamChampionships { get; set; }

        public virtual DbSet<UserTeamChampionship> UserTeamChampionships { get; set; }

        public virtual DbSet<CalendarResult> CalendarResults { get; set; }

        public virtual DbSet<RoleChampionship> RoleChampionships { get; set; }

        public RankingDbContext(DbContextOptions<RankingDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BinaryObject>(b =>
            {
                b.HasIndex(e => new { e.TenantId });
            });

            modelBuilder.Entity<ChatMessage>(b =>
            {
                b.HasIndex(e => new { e.TenantId, e.UserId, e.ReadState });
                b.HasIndex(e => new { e.TenantId, e.TargetUserId, e.ReadState });
                b.HasIndex(e => new { e.TargetTenantId, e.TargetUserId, e.ReadState });
                b.HasIndex(e => new { e.TargetTenantId, e.UserId, e.ReadState });
            });

            modelBuilder.Entity<Friendship>(b =>
            {
                b.HasIndex(e => new { e.TenantId, e.UserId });
                b.HasIndex(e => new { e.TenantId, e.FriendUserId });
                b.HasIndex(e => new { e.FriendTenantId, e.UserId });
                b.HasIndex(e => new { e.FriendTenantId, e.FriendUserId });
            });

            modelBuilder.Entity<Tenant>(b =>
            {
                b.HasIndex(e => new { e.SubscriptionEndDateUtc });
                b.HasIndex(e => new { e.CreationTime });
            });

            modelBuilder.Entity<SubscriptionPayment>(b =>
            {
                b.HasIndex(e => new { e.Status, e.CreationTime });
                b.HasIndex(e => new { PaymentId = e.ExternalPaymentId, e.Gateway });
            });

            modelBuilder.Entity<SubscriptionPaymentExtensionData>(b =>
            {
                b.HasQueryFilter(m => !m.IsDeleted)
                    .HasIndex(e => new { e.SubscriptionPaymentId, e.Key, e.IsDeleted })
                    .IsUnique();
            });

            modelBuilder.Entity<UserDelegation>(b =>
            {
                b.HasIndex(e => new { e.TenantId, e.SourceUserId });
                b.HasIndex(e => new { e.TenantId, e.TargetUserId });
            });

            modelBuilder.Entity<Championship>(b =>
            {
                b.HasIndex(e => new { e.TenantId });
            });

            modelBuilder.Entity<TeamChampionship>(b =>
            {
                b.HasIndex(e => new { e.TenantId, e.ChampionshipId, e.Id });
            });

            modelBuilder.Entity<CalendarChampionship>(b =>
            {
                b.HasIndex(e => new { e.TenantId, e.ChampionshipId, e.Id });
            });

            modelBuilder.Entity<UserTeamChampionship>(b =>
            {
                b.HasIndex(e => new { e.TenantId, e.UserId, e.Id, e.TeamId });
            });

            modelBuilder.Entity<RoleChampionship>(b =>
            {
                b.HasIndex(e => new { e.TenantId, e.ChampionshipId, e.Id });
            });

            modelBuilder.Entity<CalendarResult>(b =>
            {
                b.HasIndex(e => new { e.TenantId, e.CalendarId, e.Id, e.UserId });
            });

            modelBuilder.ConfigurePersistedGrantEntity();
        }
    }
}