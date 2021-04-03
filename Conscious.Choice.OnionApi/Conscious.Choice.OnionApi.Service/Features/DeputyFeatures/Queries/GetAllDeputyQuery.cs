using Conscious.Choice.OnionApi.Domain.Entities;
using Conscious.Choice.OnionApi.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Conscious.Choice.OnionApi.Service.Features.DeputyFeatures.Queries
{
    public class GetAllDeputyQuery : IRequest<IEnumerable<Deputy>>
    {
        public class GetAllDeputyQueryHandler : IRequestHandler<GetAllDeputyQuery, IEnumerable<Deputy>>
        {
            private readonly IApplicationDbContext _context;
            public GetAllDeputyQueryHandler(IApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<IEnumerable<Deputy>> Handle(GetAllDeputyQuery request, CancellationToken cancellationToken)
            {
                var DeputyList = await _context.Deputies.ToListAsync();
                if (DeputyList == null)
                {
                    return null;
                }
                return DeputyList.AsReadOnly();
            }
        }
    }
}
