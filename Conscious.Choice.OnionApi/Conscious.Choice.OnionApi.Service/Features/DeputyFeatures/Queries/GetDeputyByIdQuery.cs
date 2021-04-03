using Conscious.Choice.OnionApi.Domain.Entities;
using Conscious.Choice.OnionApi.Persistence;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Conscious.Choice.OnionApi.Service.Features.DeputyFeatures.Queries
{
    public class GetDeputyByIdQuery : IRequest<Deputy>
    {
        public int Id { get; set; }
        public class GetDeputyByIdQueryHandler : IRequestHandler<GetDeputyByIdQuery, Deputy>
        {
            private readonly IApplicationDbContext _context;
            public GetDeputyByIdQueryHandler(IApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<Deputy> Handle(GetDeputyByIdQuery request, CancellationToken cancellationToken)
            {
                var Deputy = _context.Deputies.Where(a => a.Id == request.Id).FirstOrDefault();
                if (Deputy == null) return null;
                return Deputy;
            }
        }
    }
}
