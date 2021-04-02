using Conscious.Choice.OnionApi.Persistence;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Conscious.Choice.OnionApi.Service.Features.LawFeatures.Commands
{
    public class UpdateLawCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string LawName { get; set; }
        public DateTime OfferDate { get; set; }
        public class UpdateLawCommandHandler : IRequestHandler<UpdateLawCommand, int>
        {
            private readonly IApplicationDbContext _context;
            public UpdateLawCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<int> Handle(UpdateLawCommand request, CancellationToken cancellationToken)
            {
                var law = _context.Laws.Where(a => a.Id == request.Id).FirstOrDefault();

                if (law == null)
                {
                    return default;
                }
                else
                {
                    law.LawName = request.LawName;
                    law.OfferDate = request.OfferDate;
                    _context.Laws.Update(law);
                    await _context.SaveChangesAsync();
                    return law.Id;
                }
            }
        }
    }
}
