using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MyGadgets.Domain.Entities;
using MyGadgets.Domain.Exceptions;
using MyGadgets.Domain.Repositories;
using MyGadgets.Infrastructure.Data;

namespace MyGadgets.Infrastructure;
public class GadgetRepository : IGadgetRepository
{
    private readonly AppDbContext _dbContext;
    private readonly ILogger<GadgetRepository> _logger;

    public GadgetRepository(AppDbContext dbContext,
        ILogger<GadgetRepository> logger)
    {
        _dbContext = dbContext;
        _logger = logger;
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

    public async Task DeleteById(int id)
    {
        var gadget = await _dbContext.Gadgets.SingleOrDefaultAsync(g => g.Id == id);

        if (gadget is null)
        {
            _logger.LogWarning("Gadget with Id={id} was tried to be deleted, but it did not exist", id);
            return;
        }

        _dbContext.Gadgets.Remove(gadget);
    }
}
