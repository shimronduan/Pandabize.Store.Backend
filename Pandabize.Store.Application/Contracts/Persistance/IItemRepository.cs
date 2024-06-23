using Pandabize.Store.Domain.Entities;

namespace Pandabize.Store.Application.Contracts.Persistance
{
    public interface IItemRepository : IAsyncRepository<Item>
    {
        Task<bool> IsItemNameUnique(string name);
    }
}
