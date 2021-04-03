using Conscious.Choice.OnionApi.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Conscious.Choice.OnionApi.Service.Features.VoteFeatures.Commands
{
    public class DeleteVoteByIdCommand : IRequest<int>
    {
        public int Id { get; set; }
        public class DeleteVoteByIdCommandHandler : IRequestHandler<DeleteVoteByIdCommand, int>
        {
            private readonly IApplicationDbContext _context;
            public DeleteVoteByIdCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<int> Handle(DeleteVoteByIdCommand request, CancellationToken cancellationToken)
            {
                var Vote = await _context.Votes.Where(a => a.Id == request.Id).FirstOrDefaultAsync();
                if (Vote == null) return default;
                _context.Votes.Remove(Vote);
                await _context.SaveChangesAsync();
                return Vote.Id;
            }
        }
    }
}
