using Conscious.Choice.OnionApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Conscious.Choice.OnionApi.Persistence
{
    public interface IApplicationDbContext
    {
        DbSet<TDeputy> Deputies { get; set; }
        DbSet<TLaw> Laws { get; set; }
        DbSet<TVote> Votes { get; set; }
        DbSet<TSetting> Settings { get; set; }
        DbSet<RLawsAmendment> Amendments { get; set; }
        public DbSet<TConvocation> Convocations { get; set; }
        public DbSet<TParty> Parties { get; set; }
        public DbSet<RPartyConvocation> PartyConvocations { get; set; }
        public DbSet<RDeputyPartyMovingsHistory> DeputyPartyMovingsHistories { get; set; }
        public DbSet<RDeputyUser> DeputyUsers { get; set; }
        Task<int> SaveChangesAsync();
    }
}
