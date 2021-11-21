using Conscious.Choice.OnionApi.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Conscious.Choice.OnionApi.Service.Features.ConvocationFeatures.Commands
{
    public class DeleteConvocationByIdCommand : IRequest<int>
    {
        public int Id { get; set; }
        public class DeleteLawByIdCommandHandler : IRequestHandler<DeleteConvocationByIdCommand, int>
        {
            private readonly IApplicationDbContext _context;
            public DeleteLawByIdCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<int> Handle(DeleteConvocationByIdCommand request, CancellationToken cancellationToken)
            {
                var convocation = await _context.Convocations.Where(a => a.Id == request.Id).FirstOrDefaultAsync();
                if (convocation == null) return default;
                _context.Convocations.Remove(convocation);
                await _context.SaveChangesAsync();
                return convocation.Id;
            }
        }
    }
}
