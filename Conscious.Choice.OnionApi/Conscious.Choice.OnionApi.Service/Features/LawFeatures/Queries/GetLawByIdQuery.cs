using Conscious.Choice.OnionApi.Domain.Entities;
using Conscious.Choice.OnionApi.Persistence;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Conscious.Choice.OnionApi.Service.Features.LawFeatures.Queries
{
    public class GetLawByIdQuery : IRequest<TLaw>
    {
        public int Id { get; set; }
        public class GetLawByIdQueryHandler : IRequestHandler<GetLawByIdQuery, TLaw>
        {
            private readonly IApplicationDbContext _context;
            public GetLawByIdQueryHandler(IApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<TLaw> Handle(GetLawByIdQuery request, CancellationToken cancellationToken)
            {
                var Law = _context.Laws.Where(a => a.Id == request.Id).FirstOrDefault();
                if (Law == null) return null;
                return Law;
            }
        }
    }
}
