using Conscious.Choice.OnionApi.Domain.Entities;
using Conscious.Choice.OnionApi.Persistence;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Conscious.Choice.OnionApi.Service.Features.LawFeatures.Commands
{
    public class CreateLawCommand : IRequest<int>
    {
        public string LawName { get; set; }
        public DateTime OfferDate { get; set; }
        public class CreateLawCommandHandler : IRequestHandler<CreateLawCommand, int>
        {
            private readonly IApplicationDbContext _context;
            public CreateLawCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<int> Handle(CreateLawCommand request, CancellationToken cancellationToken)
            {
                var Law = new TLaw();
                Law.LawName = request.LawName;

                _context.Laws.Add(Law);
                await _context.SaveChangesAsync();
                return Law.Id;
            }
        }
    }
}
