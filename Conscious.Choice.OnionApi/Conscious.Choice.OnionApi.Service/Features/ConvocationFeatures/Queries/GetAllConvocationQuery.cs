using Conscious.Choice.OnionApi.Domain.Entities;
using Conscious.Choice.OnionApi.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Conscious.Choice.OnionApi.Service.Features.ConvocationFeatures.Queries
{
    public class GetAllConvocationQuery : IRequest<IEnumerable<TConvocation>>
    {

        public class GetAllLawQueryHandler : IRequestHandler<GetAllConvocationQuery, IEnumerable<TConvocation>>
        {
            private readonly IApplicationDbContext _context;
            public GetAllLawQueryHandler(IApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<IEnumerable<TConvocation>> Handle(GetAllConvocationQuery request, CancellationToken cancellationToken)
            {
                var convocations = await _context.Convocations.ToListAsync();
                if (convocations == null)
                {
                    return null;
                }
                return convocations.AsReadOnly();
            }
        }
    }
}
