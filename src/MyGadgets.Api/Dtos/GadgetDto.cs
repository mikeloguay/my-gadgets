using MyGadgets.Domain.Entities;

namespace MyGadgets.Api.Dtos;

public record GadgetDto
{
    public int? Id { get; set; }
    public required string Name { get; set; }
    public DateOnly? PurchaseDate { get; set; }
    public string? Notes { get; set; }
    public Brand? Brand { get; set; }
    public GadgetType? Type { get; set; }

    public static GadgetDto FromEntity(Gadget gadget) => new()
    {
        Id = gadget.Id,
        Name = gadget.Name,
        PurchaseDate = gadget.PurchaseDate,
        Notes = gadget.Notes,
        Brand = gadget.Brand,
        Type = gadget.Type,
    };

    public virtual Gadget ToGadget() => new()
    {
        Id = Id ?? 0,
        Name = Name,
        PurchaseDate = PurchaseDate,
        Notes = Notes,
        Brand = Brand,
        Type = Type
    };
}
