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
    public class GetDeputyVotesByNameQuery : IRequest<MDeputy>
    {
        public string Name { get; set; }
        public class GetDeputyVotesByNameQueryHandler : IRequestHandler<GetDeputyVotesByNameQuery, MDeputy>
        {
            private readonly IApplicationDbContext _context;
            public GetDeputyVotesByNameQueryHandler(IApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<MDeputy> Handle(GetDeputyVotesByNameQuery request, CancellationToken cancellationToken)
            {
                MDeputy deputy = new MDeputy();
                deputy.Name = request.Name;
                var deputyFromDb = _context.Deputies.Where(d => d.Name == request.Name)?.FirstOrDefault();
                if (deputyFromDb == null)
                    return null;

                int id = deputyFromDb.Id;
                var Votes = _context.Votes.Include(v => v.LawsAmendment.Law)
                                          .Where(v => v.DeputyId == id).ToList();

                deputy.Votes = Votes;
                return deputy;
            }
        }
    }
}
