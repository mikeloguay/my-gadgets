namespace MyGadgets.Domain.Entities;
public class Gadget : IAgregateRoot
{
    private const int WARRANTY_YEARS = 2;
    
    public int Id { get; set; }
    public required string Name { get; set; }
    public DateOnly? PurchaseDate { get; set; }
    public string? Notes { get; set; }
    public Brand? Brand { get; set; }
    public GadgetType? Type { get; set; }

    public DateOnly? WarrantyExpirationDate => PurchaseDate.HasValue ? PurchaseDate.Value.AddYears(WARRANTY_YEARS) : null;
}
