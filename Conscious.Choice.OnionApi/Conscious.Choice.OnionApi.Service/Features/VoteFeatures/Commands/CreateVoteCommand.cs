﻿using Conscious.Choice.OnionApi.Domain.Entities;
using Conscious.Choice.OnionApi.Persistence;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Conscious.Choice.OnionApi.Service.Features.VoteFeatures.Commands
{
    public class CreateVoteCommand : IRequest<int>
    {
        public int LawsAmendemntId { get; set; }
        public int DeputyId { get; set; }
        public Decision Decision { get; set; }
        public class CreateVoteCommandHandler : IRequestHandler<CreateVoteCommand, int>
        {
            private readonly IApplicationDbContext _context;
            public CreateVoteCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<int> Handle(CreateVoteCommand request, CancellationToken cancellationToken)
            {
                var vote = new TVote();
                vote.Decision = request.Decision;
                vote.DeputyId = request.DeputyId;
                vote.LawsAmendmentId = request.LawsAmendemntId;

                _context.Votes.Add(vote);
                await _context.SaveChangesAsync();
                return vote.Id;
            }
        }
    }
}
