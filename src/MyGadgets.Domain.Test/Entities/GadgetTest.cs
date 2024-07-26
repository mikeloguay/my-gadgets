using FluentAssertions;
using MyGadgets.Domain.Entities;

namespace MyGadgets.Domain.Test.Entities;

public class GadgetTest
{
    [Fact]
    public void PurchaseDateInformed_WarrantyExpirationDate_OK()
    {
        DateOnly purchaseDate = new(2024, 7, 26);
        Gadget gadget = new() { Name = "My laptop", PurchaseDate = purchaseDate };

        gadget.WarrantyExpirationDate.Should().Be(purchaseDate.AddYears(2));
    }
}