using Conscious.Choice.OnionApi.Domain.Entities;
using Conscious.Choice.OnionApi.Persistence;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Conscious.Choice.OnionApi.Service.Features.ConvocationFeatures.Commands
{
    public class CreateConvocationCommand : IRequest<int>
    {
        public int ConvocationNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public class CreateLawCommandHandler : IRequestHandler<CreateConvocationCommand, int>
        {
            private readonly IApplicationDbContext _context;
            public CreateLawCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<int> Handle(CreateConvocationCommand request, CancellationToken cancellationToken)
            {
                var convocation = new TConvocation();
                convocation.ConvocationNumber = request.ConvocationNumber;

                _context.Convocations.Add(convocation);
                await _context.SaveChangesAsync();
                return convocation.Id;
            }
        }
    }
}
