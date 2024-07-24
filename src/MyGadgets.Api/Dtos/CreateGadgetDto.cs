using MyGadgets.Domain.Entities;

namespace MyGadgets.Api.Dtos;

public record CreateGadgetDto : GadgetDto
{
    public override Gadget ToGadget() => new()
    {
        Name = Name,
        PurchaseDate = PurchaseDate,
        Notes = Notes,
        Brand = Brand,
        Type = Type
    };
}
