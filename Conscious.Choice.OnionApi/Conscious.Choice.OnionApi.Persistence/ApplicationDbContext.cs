using Conscious.Choice.OnionApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Conscious.Choice.OnionApi.Persistence
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        // This constructor is used of runit testing
        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<TDeputy> Deputies { get; set; }
        public DbSet<TLaw> Laws { get; set; }
        public DbSet<TVote> Votes { get; set; }
        public DbSet<TLawsAmendment> Amendments { get; set; }
        public DbSet<TSetting> Settings { get; set; }
        public DbSet<TConvocation> Convocations { get; set; }
        public DbSet<TParty> Parties { get; set; }
        public DbSet<RPartyConvocation> PartyConvocations { get; set; }
        public DbSet<RDeputyPartyMovingsHistory> DeputyPartyMovingsHistories { get; set; }
        public DbSet<RDeputyUser> DeputyUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderDetail>().HasKey(o => new { o.OrderId, o.ProductId });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("DataSource=Panakota.db");
            }

        }

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }
    }
}
