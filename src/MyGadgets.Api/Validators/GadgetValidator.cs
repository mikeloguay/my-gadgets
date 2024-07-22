using FluentValidation;
using MyGadgets.Domain.Entities;

namespace MyGadgets.Api.Validators;

public class GadgetValidator : AbstractValidator<Gadget>
{
    public GadgetValidator()
    {
        RuleFor(g => g.Name)
            .NotEmpty()
            .Length(1, 50);
    }
}
