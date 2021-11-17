using Conscious.Choice.OnionApi.Service.Features.VoteFeatures.Commands;
using Conscious.Choice.OnionApi.Service.Features.VoteFeatures.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace Conscious.Choice.OnionApi.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/Vote")]
    [ApiVersion("1.0")]
    public class VoteController : ControllerBase
    {
        private IMediator _mediator;
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

        #region Auxilary getters
        [HttpGet("amendment/{id}")]
        public async Task<IActionResult> GetVotesByAmendmentId(int id)
        {
            return Ok(await Mediator.Send(new GetPartiesByAmendmentIdQuery { Id = id }));
        }
        #endregion

        #region CRUD
        [HttpPost]
        public async Task<IActionResult> Create(CreateVoteCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await Mediator.Send(new GetAllVoteQuery()));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await Mediator.Send(new GetVoteByIdQuery { Id = id }));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await Mediator.Send(new DeleteVoteByIdCommand { Id = id }));
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UpdateVoteCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }
            return Ok(await Mediator.Send(command));
        }

        #endregion
    }
}
