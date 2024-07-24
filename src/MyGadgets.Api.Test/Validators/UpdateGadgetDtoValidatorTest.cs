using FluentValidation.TestHelper;
using MyGadgets.Api.Dtos;
using MyGadgets.Api.Validators;

namespace MyGadgets.Api.Test.Validators;

public class UpdateGadgetDtoValidatorTest
{
    public readonly UpdateGadgetDtoValidator _sut;

    public UpdateGadgetDtoValidatorTest()
    {
        _sut = new UpdateGadgetDtoValidator();
    }

    [Fact]
    public void UpdateGadgetDtoValid_Validate_OK()
    {
        UpdateGadgetDto validDto = new()
        {
            Id = 1,
            Name = "Raspberry"
        };

        _sut.TestValidate(validDto).ShouldNotHaveValidationErrorFor(g => g.Name);
    }

    [Fact]
    public void UpdateGadgetDtoInvalid_Validate_OK()
    {
        UpdateGadgetDto invalidDto = new()
        {
            Id = 0,
            Name = ""
        };

        _sut.TestValidate(invalidDto).ShouldHaveValidationErrorFor(g => g.Id);
        _sut.TestValidate(invalidDto).ShouldHaveValidationErrorFor(g => g.Name);
    }
}