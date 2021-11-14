using Conscious.Choice.OnionApi.Domain.Entities;
using Conscious.Choice.OnionApi.Persistence;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Conscious.Choice.OnionApi.Service.Features.PartyFeatures.Commands
{
    public class UpdatePartyCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public int? IdLeaderDeputy { get; set; }
        public int? IdParentParty { get; set; }
        public class UpdatePartyCommandHandler : IRequestHandler<UpdatePartyCommand, int>
        {
            private readonly IApplicationDbContext _context;
            public UpdatePartyCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<int> Handle(UpdatePartyCommand request, CancellationToken cancellationToken)
            {
                var party = _context.Parties.Where(a => a.Id == request.Id).FirstOrDefault();

                if (party == null)
                {
                    return default;
                }
                else
                {
                    party.Name = request.Name;
                    party.Description = request.Description;
                    party.CreationDate = request.CreationDate;
                    party.IdLeaderDeputy = request.IdLeaderDeputy;
                    party.IdParentParty = request.IdParentParty;
                    _context.Parties.Update(party);
                    await _context.SaveChangesAsync();
                    return party.Id;
                }
            }
        }
    }
}
