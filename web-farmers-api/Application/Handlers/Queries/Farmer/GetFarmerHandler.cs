using AutoMapper;
using MediatR;
using System.Reflection.Metadata.Ecma335;
using web_farmers_api.Application.DTOs.Farmer;
using web_farmers_api.Application.Requests.Queries.Farmer;

namespace web_farmers_api.Application.Handlers.Queries.Farmer
{
    public class GetFarmerHandler : IRequestHandler<GetFarmerRequest, List<FarmerDto>>
    {
        private readonly IMapper _mapper;

        private readonly IFarmerRepository _repository;

        public GetFarmerHandler(IFarmerRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<List<FarmerDto>> Handle(GetFarmerRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var farmerList = await _repository.GetAll();
                List<FarmerDto> result = _mapper.Map<List<FarmerDto>>(farmerList);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
