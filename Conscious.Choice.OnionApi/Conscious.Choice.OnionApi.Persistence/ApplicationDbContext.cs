using Conscious.Choice.OnionApi.Domain.Auth;
using Conscious.Choice.OnionApi.Domain.Entities;
using Conscious.Choice.OnionApi.Persistence.Seeds;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Conscious.Choice.OnionApi.Persistence
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IApplicationDbContext
    {
        // This constructor is used of runit testing
        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public DbSet<TDeputy> Deputies { get; set; }
        public DbSet<TLaw> Laws { get; set; }
        public DbSet<TVote> Votes { get; set; }
        public DbSet<RLawsAmendment> Amendments { get; set; }
        public DbSet<TSetting> Settings { get; set; }
        public DbSet<TConvocation> Convocations { get; set; }
        public DbSet<TParty> Parties { get; set; }
        public DbSet<RPartyConvocation> PartyConvocations { get; set; }
        public DbSet<RDeputyPartyMovingsHistory> DeputyPartyMovingsHistories { get; set; }
        public DbSet<RDeputyUser> DeputyUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("Identity");
            modelBuilder.Entity<ApplicationUser>(entity =>
            {
                entity.ToTable(name: "User");
            });

            modelBuilder.Entity<IdentityRole>(entity =>
            {
                entity.ToTable(name: "Role");
            });
            modelBuilder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.ToTable("UserRoles");
            });

            modelBuilder.Entity<IdentityUserClaim<string>>(entity =>
            {
                entity.ToTable("UserClaims");
            });

            modelBuilder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.ToTable("UserLogins");
            });

            modelBuilder.Entity<IdentityRoleClaim<string>>(entity =>
            {
                entity.ToTable("RoleClaims");
            });

            modelBuilder.Entity<IdentityUserToken<string>>(entity =>
            {
                entity.ToTable("UserTokens");
            });

            modelBuilder.Seed();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //MS sql
            //if (!optionsBuilder.IsConfigured)
            //{
            //    optionsBuilder
            //    .UseSqlServer("DataSource=Panakota.db");
            //}

            //sqlLite
            optionsBuilder
                .UseSqlite("Filename=Panakota.db");
        }

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }
    }
}
