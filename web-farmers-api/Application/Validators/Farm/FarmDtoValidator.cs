using FluentValidation;
using web_farmers_api.Application.DTOs.Farm;
using web_farmers_api.Application.Interface.Validators.Farm;

namespace web_farmers_api.Application.Validators.Farm
{
    public class FarmDtoValidator: AbstractValidator<FarmDto>
    {
        private readonly IFarmRepository _repository;

        public FarmDtoValidator(IFarmRepository repository)
        {
            _repository = repository;
            Include(new IFarmDtoValidator(_repository));
        }
    }
}
