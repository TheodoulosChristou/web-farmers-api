using MediatR;
using web_farmers_api.Application.DTOs.Farmer;

namespace web_farmers_api.Application.Requests.Commands.Farmer
{
    public class UpdateFarmerCommand: IRequest<FarmerDto>
    {
        public FarmerDto UpdateFarmer { get; set; }
    }
}
