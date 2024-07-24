using MyGadgets.Domain.Entities;

namespace MyGadgets.Domain.Repositories;
public interface IGadgetRepository
{
    Task SaveChanges();

    Task<List<Gadget>> GetAll();
    Task<Gadget> GetById(int id);
    Task Add(Gadget gadget);
    void Update(Gadget gadget);
}
