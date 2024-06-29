using MediatR;
using web_farmers_api.Application.DTOs.Farmer;

namespace web_farmers_api.Application.Requests.Queries.Farmer
{
    public class GetFarmerRequest: IRequest<List<FarmerDto>>
    {

    }
}
