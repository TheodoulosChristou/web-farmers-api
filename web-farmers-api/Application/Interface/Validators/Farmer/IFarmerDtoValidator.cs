using FluentValidation;
using web_farmers_api.Application.DTOs.Farmer;

namespace web_farmers_api.Application.Interface.Validators.Farmer
{
    public class IFarmerDtoValidator:AbstractValidator<FarmerDto>
    {
        private readonly IFarmerRepository _repository;

        public IFarmerDtoValidator(IFarmerRepository repository)
        {
            RuleFor(x => x.EMAIL).NotEmpty().WithMessage("EMAIL must not be null");

            RuleFor(x => x.FIRSTNAME).NotEmpty().WithMessage("FIRSTNAME must not be null");

            RuleFor(x => x.LASTNAME).NotEmpty().WithMessage("LASTNAME must not be null");

            RuleFor(x => x.PHONENUMBER).NotEmpty().WithMessage("PHONENUMBER must not be null");

            RuleFor(x => x.DOB).NotEmpty().WithMessage("DOB must not be null");
            _repository = repository;
        }
    }
}
