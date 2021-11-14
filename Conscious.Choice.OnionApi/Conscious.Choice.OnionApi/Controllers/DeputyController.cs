using Conscious.Choice.OnionApi.Service.Features.DeputyFeatures.Commands;
using Conscious.Choice.OnionApi.Service.Features.DeputyFeatures.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace Conscious.Choice.OnionApi.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/Deputy")]
    [ApiVersion("1.0")]
    public class DeputyController : ControllerBase
    {
        private IMediator _mediator;
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

        [HttpPost]
        public async Task<IActionResult> Create(CreateDeputyCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await Mediator.Send(new GetAllDeputyQuery()));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await Mediator.Send(new GetDeputyByIdQuery { Id = id }));
        }

        #region Auxiliary getters
        [HttpGet("votes/{name}")]
        public async Task<IActionResult> GetDeputyVotesByName(string name)
        {
            return Ok(await Mediator.Send(new GetDeputyVotesByNameQuery { Name = name }));
        }
        
        [HttpGet("party/name={name}&id={id}")]
        public async Task<IActionResult> GetDeputiesByPartyNameOrId(string name, int id)
        {
            return BadRequest();
        }
        #endregion

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await Mediator.Send(new DeleteDeputyByIdCommand { Id = id }));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UpdateDeputyCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }
            return Ok(await Mediator.Send(command));
        }
    }
}
