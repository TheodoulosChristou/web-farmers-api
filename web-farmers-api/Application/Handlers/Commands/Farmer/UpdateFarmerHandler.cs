using AutoMapper;
using MediatR;
using web_farmers_api.Application.DTOs.Farmer;
using web_farmers_api.Application.Requests.Commands.Farmer;
using web_farmers_api.Application.Validators.Farmer;
using web_farmers_api.Domain.Entities;


    public class UpdateFarmerHandler : IRequestHandler<UpdateFarmerCommand, FarmerDto>
    {
        private readonly IMapper _mapper;

        private readonly IFarmerRepository _repository;

        public UpdateFarmerHandler(IMapper mapper, IFarmerRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<FarmerDto> Handle(UpdateFarmerCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var validation = new FarmerDtoValidator(_repository);
                var valRes = await validation.ValidateAsync(request.UpdateFarmer);

                if(valRes.IsValid == false)
                {
                throw new Exception("Update Farmer Failed. Validation Failed");
                } else
                {
                    var farmerRequest = _mapper.Map<Farmer>(request.UpdateFarmer);
                    await _repository.Update(farmerRequest);
                    FarmerDto farmerRes = _mapper.Map<FarmerDto>(farmerRequest);
                    return farmerRes;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

