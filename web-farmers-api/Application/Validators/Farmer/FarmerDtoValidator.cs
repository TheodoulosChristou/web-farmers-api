using FluentValidation;
using web_farmers_api.Application.DTOs.Farmer;
using web_farmers_api.Application.Interface.Validators.Farmer;

namespace web_farmers_api.Application.Validators.Farmer
{
    public class FarmerDtoValidator: AbstractValidator<FarmerDto>
    {
        private readonly IFarmerRepository _repository;

        public FarmerDtoValidator(IFarmerRepository repository)
        {
            _repository = repository;
            Include(new IFarmerDtoValidator(_repository));
        }
    }
}
