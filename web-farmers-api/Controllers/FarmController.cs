using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using web_farmers_api.Application.DTOs.Farm;
using web_farmers_api.Application.Requests.Commands.Farm;

namespace web_farmers_api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FarmController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FarmController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("CreateFarm")]
        public async Task<ActionResult<IQueryable<FarmDto>>> CreateFarm([FromBody] FarmDto CreateFarm)
        {
            var request = new CreateFarmCommand { CreateFarm = CreateFarm };
            var response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
