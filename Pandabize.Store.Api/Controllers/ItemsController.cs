using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Pandabize.Store.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ItemsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(Name = "GetAllEvents")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<List<string>>> GetAllEvents()
        {
            return Ok();
        }
    }
}
