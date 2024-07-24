namespace MyGadgets.Domain.Entities;
public class Gadget
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public DateOnly? PurchaseDate { get; set; }
    public string? Notes { get; set; }
    public Brand? Brand { get; set; }
    public GadgetType? Type { get; set; }
}
