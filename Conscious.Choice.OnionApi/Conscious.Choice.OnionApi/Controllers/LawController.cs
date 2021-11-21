using Conscious.Choice.OnionApi.Service.Features.LawFeatures.Commands;
using Conscious.Choice.OnionApi.Service.Features.LawFeatures.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace Conscious.Choice.OnionApi.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/Law")]
    [ApiVersion("1.0")]
    public class LawController : ControllerBase
    {
        private IMediator _mediator;
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

        #region Auxiliary getters
        [HttpGet("{id}/amendments")]
        public async Task<IActionResult> GetAmendmentsByLawId(int id)
        {
            return Ok(await Mediator.Send(new GetLawsAmendmentsByIdQuery { Id = id }));
        }
        #endregion
        #region CRUD
        [HttpPost]
        public async Task<IActionResult> Create(CreateConvocationCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await Mediator.Send(new GetAllConvocationQuery()));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await Mediator.Send(new GetConvocationByIdQuery { Id = id }));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await Mediator.Send(new DeleteConvocationByIdCommand { Id = id }));
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UpdateConvocationCommand command)
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
