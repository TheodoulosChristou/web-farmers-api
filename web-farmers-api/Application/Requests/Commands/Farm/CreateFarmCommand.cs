using MediatR;
using web_farmers_api.Application.DTOs.Farm;

namespace web_farmers_api.Application.Requests.Commands.Farm
{
    public class CreateFarmCommand: IRequest<FarmDto>
    {
        public FarmDto CreateFarm {  get; set; }
    }
}
