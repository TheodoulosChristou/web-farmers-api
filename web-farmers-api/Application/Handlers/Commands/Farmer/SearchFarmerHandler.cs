using MediatR;
using web_farmers_api.Application.DTOs.Farmer;
using web_farmers_api.Application.Requests.Commands.Farmer;

namespace web_farmers_api.Application.Handlers.Commands.Farmer
{
    public class SearchFarmerHandler : IRequestHandler<SearchFarmerCommand, List<SearchFarmerResultDto>>
    {
        private readonly IFarmerRepository _repository;

        public SearchFarmerHandler(IFarmerRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<SearchFarmerResultDto>> Handle(SearchFarmerCommand request, CancellationToken cancellationToken)
        {
            try
            {
                List<SearchFarmerResultDto> res = await _repository.SearchFarmersByCriteria(request.searchCriteria);
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
