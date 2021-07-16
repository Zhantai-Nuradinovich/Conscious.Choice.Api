using Conscious.Choice.OnionApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Conscious.Choice.OnionApi.Persistence
{
    public interface IApplicationDbContext
    {
        DbSet<Category> Categories { get; set; }
        DbSet<Customer> Customers { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<Supplier> Suppliers { get; set; }
        DbSet<TDeputy> Deputies { get; set; }
        DbSet<TLaw> Laws { get; set; }
        DbSet<TVote> Votes { get; set; }
        DbSet<TSetting> Settings { get; set; }
        DbSet<TLawsAmendment> Amendments { get; set; }
        Task<int> SaveChangesAsync();
    }
}
