using FluentValidation;
using MyGadgets.Api.Dtos;

namespace MyGadgets.Api.Validators;

public class CreateGadgetDtoValidator : AbstractValidator<CreateGadgetDto>
{
    public CreateGadgetDtoValidator()
    {
        RuleFor(g => g.Id)
            .Empty();

        RuleFor(g => g.Name)
            .NotEmpty()
            .Length(1, 50);
    }
}
