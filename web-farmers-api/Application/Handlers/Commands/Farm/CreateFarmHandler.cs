using AutoMapper;
using MediatR;
using web_farmers_api.Application.DTOs.Farm;
using web_farmers_api.Application.Requests.Commands.Farm;
using web_farmers_api.Application.Validators.Farm;
using web_farmers_api.Domain.Entities;

    public class CreateFarmHandler : IRequestHandler<CreateFarmCommand, FarmDto>
    {
        private readonly IFarmRepository _repository;

        private readonly IMapper _mapper;

        public CreateFarmHandler(IFarmRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<FarmDto> Handle(CreateFarmCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var validator = new FarmDtoValidator(_repository);
                var valRes = await validator.ValidateAsync(request.CreateFarm);

                if(valRes.IsValid == false)
                {
                    throw new Exception("Create Farm Failed. Validation Failed");
                } else
                {
                    var farmRequest = _mapper.Map<Farm>(request.CreateFarm);
                    var farmResponse = await _repository.Add(farmRequest);
                    FarmDto res = _mapper.Map<FarmDto>(farmResponse);
                    return res;    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

