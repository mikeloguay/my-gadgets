using FluentValidation.TestHelper;
using MyGadgets.Api.Dtos;
using MyGadgets.Api.Validators;

namespace MyGadgets.Api.Test.Validators;

public class CreateGadgetDtoValidatorTest
{
    public readonly CreateGadgetDtoValidator _sut;

    public CreateGadgetDtoValidatorTest()
    {
        _sut = new CreateGadgetDtoValidator();
    }

    [Fact]
    public void CreateGadgetDtoValid_Validate_OK()
    {
        CreateGadgetDto validDto = new()
        {
            Name = "Raspberry"
        };

        _sut.TestValidate(validDto).ShouldNotHaveValidationErrorFor(g => g.Name);
    }

    [Fact]
    public void CreateGadgetDtoInvalid_Validate_OK()
    {
        CreateGadgetDto invalidDto = new()
        {
            Name = ""
        };

        _sut.TestValidate(invalidDto).ShouldHaveValidationErrorFor(g => g.Name);
    }
}