using Conscious.Choice.OnionApi.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Conscious.Choice.OnionApi.Service.Features.DeputyFeatures.Commands
{
    public class DeleteDeputyByIdCommand : IRequest<int>
    {
        public int Id { get; set; }
        public class DeleteDeputyByIdCommandHandler : IRequestHandler<DeleteDeputyByIdCommand, int>
        {
            private readonly IApplicationDbContext _context;
            public DeleteDeputyByIdCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<int> Handle(DeleteDeputyByIdCommand request, CancellationToken cancellationToken)
            {
                var Deputy = await _context.Deputies.Where(a => a.Id == request.Id).FirstOrDefaultAsync();
                if (Deputy == null) return default;
                _context.Deputies.Remove(Deputy);
                await _context.SaveChangesAsync();
                return Deputy.Id;
            }
        }
    }
}
