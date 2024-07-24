using Microsoft.EntityFrameworkCore;
using MyGadgets.Domain.Entities;
using MyGadgets.Domain.Exceptions;
using MyGadgets.Domain.Repositories;
using MyGadgets.Infrastructure.Data;

namespace MyGadgets.Infrastructure;
public class GadgetRepository : IGadgetRepository
{
    private readonly AppDbContext _dbContext;

    public GadgetRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task SaveChanges()
    {
        await _dbContext.SaveChangesAsync();
    }

    public async Task<List<Gadget>> GetAll() => await _dbContext.Gadgets.ToListAsync();

    public async Task<Gadget> GetById(int id)
    {
        var gadget = await _dbContext.Gadgets.SingleOrDefaultAsync(g => g.Id == id);

        return gadget is null ? throw new EntityNotFoundException(nameof(Gadget), id) : gadget;
    }

    public async Task Add(Gadget gadget)
    {
        await _dbContext.Gadgets.AddAsync(gadget);
    }

    public void Update(Gadget gadget)
    {
        _dbContext.Gadgets.Update(gadget);
    }
}
