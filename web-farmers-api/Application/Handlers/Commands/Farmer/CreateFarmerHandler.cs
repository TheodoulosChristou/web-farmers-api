using AutoMapper;
using MediatR;
using web_farmers_api.Application.DTOs.Farmer;
using web_farmers_api.Application.Requests.Commands.Farmer;
using web_farmers_api.Application.Validators.Farmer;
using web_farmers_api.Domain.Entities;

public class CreateFarmerHandler : IRequestHandler<CreateFarmerCommand, FarmerDto>
{
    private readonly IMapper _mapper;

    private readonly IFarmerRepository _repository;

    public CreateFarmerHandler(IMapper mapper, IFarmerRepository repository)
    {
        _mapper = mapper;
        _repository = repository;
    }

    public async Task<FarmerDto> Handle(CreateFarmerCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var validator = new FarmerDtoValidator(_repository);
            var valRes = await validator.ValidateAsync(request.CreateFarmer);

            if (valRes.IsValid == false)
            {
                throw new Exception("Unable to create Farmer. Validation Failed");
            }
            else
            {
                var farmerRequest = _mapper.Map<Farmer>(request.CreateFarmer);
                var farmerResponse = await _repository.Add(farmerRequest);
                FarmerDto result = _mapper.Map<FarmerDto>(farmerResponse);
                return result;
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}
    

