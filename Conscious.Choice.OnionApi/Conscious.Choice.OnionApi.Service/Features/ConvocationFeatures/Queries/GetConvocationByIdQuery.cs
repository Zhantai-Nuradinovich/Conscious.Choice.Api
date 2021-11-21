using Conscious.Choice.OnionApi.Domain.Entities;
using Conscious.Choice.OnionApi.Persistence;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Conscious.Choice.OnionApi.Service.Features.ConvocationFeatures.Queries
{
    public class GetConvocationByIdQuery : IRequest<TConvocation>
    {
        public int Id { get; set; }
        public class GetLawByIdQueryHandler : IRequestHandler<GetConvocationByIdQuery, TConvocation>
        {
            private readonly IApplicationDbContext _context;
            public GetLawByIdQueryHandler(IApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<TConvocation> Handle(GetConvocationByIdQuery request, CancellationToken cancellationToken)
            {
                var convocation = _context.Convocations.Where(a => a.Id == request.Id).FirstOrDefault();
                if (convocation == null) return null;
                return convocation;
            }
        }
    }
}
