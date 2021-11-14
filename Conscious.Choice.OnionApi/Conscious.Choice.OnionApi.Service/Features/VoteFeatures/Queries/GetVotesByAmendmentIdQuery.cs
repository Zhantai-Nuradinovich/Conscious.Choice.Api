using Conscious.Choice.OnionApi.Domain.Entities;
using Conscious.Choice.OnionApi.Persistence;
using MediatR;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Conscious.Choice.OnionApi.Service.Features.VoteFeatures.Queries
{
    public class GetPartiesByAmendmentIdQuery : IRequest<IEnumerable<TVote>>
    {
        public int Id { get; set; }
        public class GetVotesByAmendmentIdQueryHandler : IRequestHandler<GetPartiesByAmendmentIdQuery, IEnumerable<TVote>>
        {
            private readonly IApplicationDbContext _context;
            public GetVotesByAmendmentIdQueryHandler(IApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<IEnumerable<TVote>> Handle(GetPartiesByAmendmentIdQuery request, CancellationToken cancellationToken)
            {
                var Votes = _context.Votes.Where(a => a.LawsAmendmentId == request.Id);
                if (Votes == null) return null;
                return Votes;
            }
        }
    }
}
