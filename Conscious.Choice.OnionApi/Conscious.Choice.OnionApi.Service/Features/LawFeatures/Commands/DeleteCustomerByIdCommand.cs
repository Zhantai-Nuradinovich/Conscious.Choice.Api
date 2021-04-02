using Conscious.Choice.OnionApi.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Conscious.Choice.OnionApi.Service.Features.LawFeatures.Commands
{
    public class DeleteLawByIdCommand : IRequest<int>
    {
        public int Id { get; set; }
        public class DeleteLawByIdCommandHandler : IRequestHandler<DeleteLawByIdCommand, int>
        {
            private readonly IApplicationDbContext _context;
            public DeleteLawByIdCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<int> Handle(DeleteLawByIdCommand request, CancellationToken cancellationToken)
            {
                var Law = await _context.Laws.Where(a => a.Id == request.Id).FirstOrDefaultAsync();
                if (Law == null) return default;
                _context.Laws.Remove(Law);
                await _context.SaveChangesAsync();
                return Law.Id;
            }
        }
    }
}
