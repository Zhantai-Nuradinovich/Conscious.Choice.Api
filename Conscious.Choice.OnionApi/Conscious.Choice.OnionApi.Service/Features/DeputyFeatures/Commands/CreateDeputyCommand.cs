using Conscious.Choice.OnionApi.Domain.Entities;
using Conscious.Choice.OnionApi.Persistence;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Conscious.Choice.OnionApi.Service.Features.DeputyFeatures.Commands
{
    public class CreateDeputyCommand : IRequest<int>
    {
        public string Name { get; set; }
        public class CreateDeputyCommandHandler : IRequestHandler<CreateDeputyCommand, int>
        {
            private readonly IApplicationDbContext _context;
            public CreateDeputyCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<int> Handle(CreateDeputyCommand request, CancellationToken cancellationToken)
            {
                var deputy = new TDeputy();
                deputy.Name = request.Name;

                _context.Deputies.Add(deputy);
                await _context.SaveChangesAsync();
                return deputy.Id;
            }
        }
    }
}
