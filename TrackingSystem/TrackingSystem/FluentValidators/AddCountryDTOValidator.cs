using FluentValidation;
using TrackingSystem.DTO;

namespace TrackingSystem.FluentValidators
{
    public class AddCountryDTOValidator:AbstractValidator<AddCountryDTO>
    {
        public AddCountryDTOValidator()
        {
            RuleFor(s => s.Name)
                .NotEmpty()
                .MinimumLength(3)
                .MaximumLength(30);
            RuleFor(s => s.CountryCode)
                .GreaterThan(0)
                .NotEmpty();
        }
    }
}
