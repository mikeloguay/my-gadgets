using Microsoft.EntityFrameworkCore;
using MyGadgets.Domain.Entities;

namespace MyGadgets.Infrastructure.Data;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Gadget> Gadgets { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
