using Conscious.Choice.OnionApi.Persistence;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Conscious.Choice.OnionApi.Service.Features.DeputyFeatures.Commands
{
    public class UpdateDeputyCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public class UpdateDeputyCommandHandler : IRequestHandler<UpdateDeputyCommand, int>
        {
            private readonly IApplicationDbContext _context;
            public UpdateDeputyCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<int> Handle(UpdateDeputyCommand request, CancellationToken cancellationToken)
            {
                var dep = _context.Deputies.Where(a => a.Id == request.Id).FirstOrDefault();

                if (dep == null)
                {
                    return default;
                }
                else
                {
                    dep.Name = request.Name;
                    _context.Deputies.Update(dep);
                    await _context.SaveChangesAsync();
                    return dep.Id;
                }
            }
        }
    }
}
