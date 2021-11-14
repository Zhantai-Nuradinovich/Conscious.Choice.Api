using Conscious.Choice.OnionApi.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Conscious.Choice.OnionApi.Service.Features.PartyFeatures.Commands
{
    public class DeletePartyByIdCommand : IRequest<int>
    {
        public int Id { get; set; }
        public class DeletePartyByIdCommandHandler : IRequestHandler<DeletePartyByIdCommand, int>
        {
            private readonly IApplicationDbContext _context;
            public DeletePartyByIdCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<int> Handle(DeletePartyByIdCommand request, CancellationToken cancellationToken)
            {
                var party = await _context.Parties.Where(a => a.Id == request.Id).FirstOrDefaultAsync();
                if (party == null) return default;
                _context.Parties.Remove(party);
                await _context.SaveChangesAsync();
                return party.Id;
            }
        }
    }
}
