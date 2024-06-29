using AutoMapper;
using MediatR;
using web_farmers_api;
using web_farmers_api.Application.Requests.Commands.Farmer;
using web_farmers_api.Application.Validators.Farmer;
using web_farmers_api.Domain.Entities;



    public class DeleteFarmerHandler : IRequestHandler<DeleteFarmerCommand, BaseCommandResponse>
    {
        private readonly IMapper _mapper;

        private readonly IFarmerRepository _repository;

        public DeleteFarmerHandler(IFarmerRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<BaseCommandResponse> Handle(DeleteFarmerCommand request, CancellationToken cancellationToken)
        {
            try
            {
            BaseCommandResponse response = new BaseCommandResponse();
                var validation = new FarmerDtoValidator(_repository);
                var valRes = await validation.ValidateAsync(request.DeleteFarmer);

                if(valRes.IsValid == false)
                {
                    throw new Exception("Delete Farmer Failed. Validation Failed");
                } else
                {
                    var farmerRequest = _mapper.Map<Farmer>(request.DeleteFarmer);
                    await _repository.Delete(farmerRequest);
                    response.ID = farmerRequest.ID;
                    response.ENTITY = "FARMER";
                    response.SUCCESS = true;
                    response.MESSAGE = "Farmer Deleted Successfully";
                    return response;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

