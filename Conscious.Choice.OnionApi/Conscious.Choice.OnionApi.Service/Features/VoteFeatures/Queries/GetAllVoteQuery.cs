using Conscious.Choice.OnionApi.Domain.Entities;
using Conscious.Choice.OnionApi.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Conscious.Choice.OnionApi.Service.Features.VoteFeatures.Queries
{
    public class GetAllVoteQuery : IRequest<IEnumerable<Vote>>
    {

        public class GetAllVoteQueryHandler : IRequestHandler<GetAllVoteQuery, IEnumerable<Vote>>
        {
            private readonly IApplicationDbContext _context;
            public GetAllVoteQueryHandler(IApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<IEnumerable<Vote>> Handle(GetAllVoteQuery request, CancellationToken cancellationToken)
            {
                var VoteList = await _context.Votes.ToListAsync();
                if (VoteList == null)
                {
                    return null;
                }
                return VoteList.AsReadOnly();
            }
        }
    }
}
