using Conscious.Choice.OnionApi.Domain.Entities;
using Conscious.Choice.OnionApi.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Conscious.Choice.OnionApi.Service.Features.DeputyFeatures.Queries
{
    public class GetDeputyActivityQuery : IRequest<DeputyActivity>
    {
        public string Name { get; set; }
        public class GetDeputyActivityQueryHandler : IRequestHandler<GetDeputyActivityQuery, DeputyActivity>
        {
            private readonly IApplicationDbContext _context;
            public GetDeputyActivityQueryHandler(IApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<DeputyActivity> Handle(GetDeputyActivityQuery request, CancellationToken cancellationToken)
            {
                DeputyActivity deputy = new DeputyActivity();
                deputy.Name = request.Name;
                int id = _context.Deputies.Where(d => d.Name == request.Name).FirstOrDefault().Id;
                var Votes = _context.Votes.Include(v => v.Law).Where(v => v.DeputyId == id).ToList();

                deputy.Votes = Votes;
                if (deputy == null) return null;
                return deputy;
            }
        }
    }
}
