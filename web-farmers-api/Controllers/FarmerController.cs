using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using web_farmers_api.Application.DTOs.Farmer;
using web_farmers_api.Application.Requests.Commands.Farmer;

namespace web_farmers_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FarmerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FarmerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("CreateFarmer")]
        public async Task<ActionResult<IQueryable<FarmerDto>>> CreateFarmer([FromBody] FarmerDto CreateFarmer)
        {
            var request = new CreateFarmerCommand { CreateFarmer = CreateFarmer };
            var response = await _mediator.Send(request);
            return Ok(response);
        }


        [HttpPut("UpdateFarmer")]
        public async Task<ActionResult<IQueryable<FarmerDto>>> UpdateFarmer([FromBody] FarmerDto UpdateFarmer)
        {
            var request = new UpdateFarmerCommand { UpdateFarmer = UpdateFarmer };
            var response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
