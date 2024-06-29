using MediatR;
using web_farmers_api.Application.DTOs.Farmer;

namespace web_farmers_api.Application.Requests.Commands.Farmer
{
    public class SearchFarmerCommand: IRequest<List<SearchFarmerResultDto>>
    {
        public SearchFarmerCriteriaDto searchCriteria {  get; set; }
    }
}
