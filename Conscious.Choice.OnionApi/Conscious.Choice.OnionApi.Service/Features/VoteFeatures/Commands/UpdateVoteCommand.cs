using Conscious.Choice.OnionApi.Domain.Entities;
using Conscious.Choice.OnionApi.Persistence;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Conscious.Choice.OnionApi.Service.Features.VoteFeatures.Commands
{
    public class UpdateVoteCommand : IRequest<int>
    {
        public int Id { get; set; }
        public int LawsAmendmentId { get; set; }
        public int DeputyId { get; set; }
        public Decision Decision { get; set; }
        public class UpdateVoteCommandHandler : IRequestHandler<UpdateVoteCommand, int>
        {
            private readonly IApplicationDbContext _context;
            public UpdateVoteCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<int> Handle(UpdateVoteCommand request, CancellationToken cancellationToken)
            {
                var vote = _context.Votes.Where(a => a.Id == request.Id).FirstOrDefault();

                if (vote == null)
                {
                    return default;
                }
                else
                {
                    vote.Decision = request.Decision;
                    vote.LawsAmendmentId = request.LawsAmendmentId;
                    vote.DeputyId = request.DeputyId;
                    _context.Votes.Update(vote);
                    await _context.SaveChangesAsync();
                    return vote.Id;
                }
            }
        }
    }
}
