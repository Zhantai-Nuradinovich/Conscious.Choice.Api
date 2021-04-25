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
        DbSet<Deputy> Deputies { get; set; }
        DbSet<Law> Laws { get; set; }
        DbSet<Vote> Votes { get; set; }
        Task<int> SaveChangesAsync();
    }
}
