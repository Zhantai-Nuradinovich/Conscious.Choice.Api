using Conscious.Choice.OnionApi.Persistence;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Conscious.Choice.OnionApi.Service.Features.ConvocationFeatures.Commands
{
    public class UpdateConvocationCommand : IRequest<int>
    {
        public int Id { get; set; }
        public int ConvocationNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public class UpdateLawCommandHandler : IRequestHandler<UpdateConvocationCommand, int>
        {
            private readonly IApplicationDbContext _context;
            public UpdateLawCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<int> Handle(UpdateConvocationCommand request, CancellationToken cancellationToken)
            {
                var convocation = _context.Convocations.Where(a => a.Id == request.Id).FirstOrDefault();

                if (convocation == null)
                {
                    return default;
                }
                else
                {
                    convocation.ConvocationNumber = request.ConvocationNumber;
                    convocation.StartDate = request.StartDate;
                    convocation.EndDate = request.EndDate;
                    _context.Convocations.Update(convocation);
                    await _context.SaveChangesAsync();
                    return convocation.Id;
                }
            }
        }
    }
}
