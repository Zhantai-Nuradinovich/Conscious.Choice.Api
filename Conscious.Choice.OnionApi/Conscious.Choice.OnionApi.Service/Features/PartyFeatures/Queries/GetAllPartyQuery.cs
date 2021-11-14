using Conscious.Choice.OnionApi.Domain.Entities;
using Conscious.Choice.OnionApi.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Conscious.Choice.OnionApi.Service.Features.PartyFeatures.Queries
{
    public class GetAllPartyQuery : IRequest<IEnumerable<TParty>>
    {

        public class GetAllPartyQueryHandler : IRequestHandler<GetAllPartyQuery, IEnumerable<TParty>>
        {
            private readonly IApplicationDbContext _context;
            public GetAllPartyQueryHandler(IApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<IEnumerable<TParty>> Handle(GetAllPartyQuery request, CancellationToken cancellationToken)
            {
                var partyList = await _context.Parties.ToListAsync();
                if (partyList == null)
                {
                    return null;
                }
                return partyList.AsReadOnly();
            }
        }
    }
}
