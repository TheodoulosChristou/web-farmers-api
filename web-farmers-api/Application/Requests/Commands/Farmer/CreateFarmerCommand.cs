using MediatR;
using web_farmers_api.Application.DTOs.Farmer;

namespace web_farmers_api.Application.Requests.Commands.Farmer
{
    public class CreateFarmerCommand: IRequest<FarmerDto>
    {
        public FarmerDto CreateFarmer {  get; set; }
    }
}
