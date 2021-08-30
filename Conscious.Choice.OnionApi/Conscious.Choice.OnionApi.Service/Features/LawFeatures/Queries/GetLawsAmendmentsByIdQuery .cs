using Conscious.Choice.OnionApi.Domain.Entities;
using Conscious.Choice.OnionApi.Persistence;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Conscious.Choice.OnionApi.Service.Features.LawFeatures.Queries
{
    public class GetLawsAmendmentsByIdQuery : IRequest<IEnumerable<TLawsAmendment>>
    {
        public int Id { get; set; }
        public class GetLawsAmendmentsByIdQueryHandler : IRequestHandler<GetLawsAmendmentsByIdQuery, IEnumerable<TLawsAmendment>>
        {
            private readonly IApplicationDbContext _context;
            public GetLawsAmendmentsByIdQueryHandler(IApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<IEnumerable<TLawsAmendment>> Handle(GetLawsAmendmentsByIdQuery request, CancellationToken cancellationToken)
            {
                var amendments = _context.Amendments.Where(a => a.LawId == request.Id);
                if (amendments == null) return null;
                return amendments;
            }
        }
    }
}
