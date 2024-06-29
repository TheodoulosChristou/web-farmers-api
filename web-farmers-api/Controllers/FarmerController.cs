using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using web_farmers_api.Application.DTOs.Farmer;
using web_farmers_api.Application.Requests.Commands.Farmer;
using web_farmers_api.Application.Requests.Queries.Farmer;

namespace web_farmers_api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FarmerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FarmerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetAllFarmers")]
        public async Task<ActionResult<IQueryable<FarmerDto>>> GetAllFarmers()
        {
            var request = new GetFarmerRequest {  };
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost("CreateFarmer")]
        public async Task<ActionResult<IQueryable<FarmerDto>>> CreateFarmer([FromBody] FarmerDto CreateFarmer)
        {
            var request = new CreateFarmerCommand { CreateFarmer = CreateFarmer };
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost("SearchFarmerByCriteria")]
        public async Task<ActionResult<IQueryable<SearchFarmerResultDto>>> SearchFarmerByCriteria([FromBody] SearchFarmerCriteriaDto searchCriteria)
        {
            var request = new SearchFarmerCommand { searchCriteria = searchCriteria };
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


        [HttpDelete("DeleteFarmer")]
        public async Task<ActionResult<BaseCommandResponse>> DeleteFarmer([FromBody] FarmerDto DeleteFarmer)
        {
            var request = new DeleteFarmerCommand { DeleteFarmer = DeleteFarmer };
            var response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
