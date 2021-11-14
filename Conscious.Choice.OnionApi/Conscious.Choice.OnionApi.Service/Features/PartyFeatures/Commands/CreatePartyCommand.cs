using Conscious.Choice.OnionApi.Domain.Entities;
using Conscious.Choice.OnionApi.Persistence;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Conscious.Choice.OnionApi.Service.Features.PartyFeatures.Commands
{
    public class CreatePartyCommand : IRequest<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public int? IdLeaderDeputy { get; set; }
        public int? IdParentParty { get; set; }
        public class CreatePartyCommandHandler : IRequestHandler<CreatePartyCommand, int>
        {
            private readonly IApplicationDbContext _context;
            public CreatePartyCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<int> Handle(CreatePartyCommand request, CancellationToken cancellationToken)
            {
                var party = new TParty();
                party.Name = request.Name;
                party.Description = request.Description;
                party.CreationDate = request.CreationDate;
                party.IdLeaderDeputy = request.IdLeaderDeputy;
                party.IdParentParty = request.IdParentParty;

                _context.Parties.Add(party);
                await _context.SaveChangesAsync();
                return party.Id;
            }
        }
    }
}
