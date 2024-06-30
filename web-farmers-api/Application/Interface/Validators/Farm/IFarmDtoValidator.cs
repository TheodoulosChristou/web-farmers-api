using FluentValidation;
using web_farmers_api.Application.DTOs.Farm;

namespace web_farmers_api.Application.Interface.Validators.Farm
{
    public class IFarmDtoValidator: AbstractValidator<FarmDto>
    {
        private readonly IFarmRepository _repository;

        public IFarmDtoValidator(IFarmRepository repository)
        {
            RuleFor(x=>x.FARMNAME).NotEmpty().WithMessage("FARMNAME must not be null");

            RuleFor(x => x.FARMSIZE).NotNull().WithMessage("FARMSIZE must not be null");

            RuleFor(x => x.LOCATION).NotEmpty().WithMessage("LOCATION must not be null");

            RuleFor(x => x.FARMER_ID).NotNull().WithMessage("FARMER_ID must not be null");

            _repository = repository;
        }
    }
}
