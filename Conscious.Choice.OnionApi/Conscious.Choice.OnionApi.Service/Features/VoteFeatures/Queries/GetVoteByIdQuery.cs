using Conscious.Choice.OnionApi.Domain.Entities;
using Conscious.Choice.OnionApi.Persistence;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Conscious.Choice.OnionApi.Service.Features.VoteFeatures.Queries
{
    public class GetVoteByIdQuery : IRequest<TVote>
    {
        public int Id { get; set; }
        public class GetVoteByIdQueryHandler : IRequestHandler<GetVoteByIdQuery, TVote>
        {
            private readonly IApplicationDbContext _context;
            public GetVoteByIdQueryHandler(IApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<TVote> Handle(GetVoteByIdQuery request, CancellationToken cancellationToken)
            {
                var Vote = _context.Votes.Where(a => a.Id == request.Id).FirstOrDefault();
                if (Vote == null) return null;
                return Vote;
            }
        }
    }
}
