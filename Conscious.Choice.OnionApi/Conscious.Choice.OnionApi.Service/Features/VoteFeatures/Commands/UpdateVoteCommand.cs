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
        public int LawId { get; set; }
        public int DeputyId { get; set; }
        public int DecisionId { get; set; }
        public class UpdateVoteCommandHandler : IRequestHandler<UpdateVoteCommand, int>
        {
            private readonly IApplicationDbContext _context;
            public UpdateVoteCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<int> Handle(UpdateVoteCommand request, CancellationToken cancellationToken)
            {
                var cust = _context.Votes.Where(a => a.Id == request.Id).FirstOrDefault();

                if (cust == null)
                {
                    return default;
                }
                else
                {
                    cust.DecisionId = request.DecisionId;
                    cust.LawId = request.LawId;
                    cust.DeputyId = request.DeputyId;
                    _context.Votes.Update(cust);
                    await _context.SaveChangesAsync();
                    return cust.Id;
                }
            }
        }
    }
}
