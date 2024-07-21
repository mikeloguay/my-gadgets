using MyGadgets.Domain.Entities;

namespace MyGadgets.Domain.Repositories;
public interface IGadgetRepository
{
    Task<List<Gadget>> GetAll();
}
