using FluentValidation;
using MyGadgets.Api.Dtos;

namespace MyGadgets.Api.Validators;

public class UpdateGadgetDtoValidator : AbstractValidator<UpdateGadgetDto>
{
    public UpdateGadgetDtoValidator()
    {
        RuleFor(g => g.Id)
            .NotEmpty()
            .GreaterThan(0);

        RuleFor(g => g.Name)
            .NotEmpty()
            .Length(1, 50);
    }
}
