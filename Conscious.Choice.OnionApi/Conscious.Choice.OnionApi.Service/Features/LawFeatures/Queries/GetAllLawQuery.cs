using Conscious.Choice.OnionApi.Domain.Entities;
using Conscious.Choice.OnionApi.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Conscious.Choice.OnionApi.Service.Features.LawFeatures.Queries
{
    public class GetAllLawQuery : IRequest<IEnumerable<Law>>
    {

        public class GetAllLawQueryHandler : IRequestHandler<GetAllLawQuery, IEnumerable<Law>>
        {
            private readonly IApplicationDbContext _context;
            public GetAllLawQueryHandler(IApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<IEnumerable<Law>> Handle(GetAllLawQuery request, CancellationToken cancellationToken)
            {
                var LawList = await _context.Laws.ToListAsync();
                if (LawList == null)
                {
                    return null;
                }
                return LawList.AsReadOnly();
            }
        }
    }
}
