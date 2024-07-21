using MyGadgets.Domain.Entities;
using MyGadgets.Domain.Repositories;

namespace MyGadgets.Infrastructure;
public class GadgetRepository : IGadgetRepository
{
    public async Task<List<Gadget>> GetAll()
    {
        throw new NotImplementedException();
    }
}
