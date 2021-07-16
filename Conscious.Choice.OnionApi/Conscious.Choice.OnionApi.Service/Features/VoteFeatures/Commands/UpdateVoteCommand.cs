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
                var cust = _context.Votes.Where(a => a.Id == request.Id).FirstOrDefault();

                if (cust == null)
                {
                    return default;
                }
                else
                {
                    cust.Decision = request.Decision;
                    cust.LawsAmendmentId = request.LawsAmendmentId;
                    cust.DeputyId = request.DeputyId;
                    _context.Votes.Update(cust);
                    await _context.SaveChangesAsync();
                    return cust.Id;
                }
            }
        }
    }
}
