using Conscious.Choice.OnionApi.Domain.Entities;
using Conscious.Choice.OnionApi.Persistence;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Conscious.Choice.OnionApi.Service.Features.PartyFeatures.Queries
{
    public class GetPartyByIdQuery : IRequest<TParty>
    {
        public int Id { get; set; }
        public class GetPartyByIdQueryHandler : IRequestHandler<GetPartyByIdQuery, TParty>
        {
            private readonly IApplicationDbContext _context;
            public GetPartyByIdQueryHandler(IApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<TParty> Handle(GetPartyByIdQuery request, CancellationToken cancellationToken)
            {
                var party = _context.Parties.Where(a => a.Id == request.Id).FirstOrDefault();
                if (party == null) return null;
                return party;
            }
        }
    }
}
