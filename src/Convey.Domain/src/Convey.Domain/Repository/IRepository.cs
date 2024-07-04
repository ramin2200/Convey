using Convey.Domain.Entities;

namespace Convey.Domain.Repository
{
    public interface IRepository
    {
    }

    public interface IRepository<T> : IRepository where T : AggregateRoot
    {
        Task<T> GetAsync(AggregateId id);
        Task<bool> ExistsAsync(AggregateId id);
        Task AddAsync(T resource);
        Task UpdateAsync(T resource);
        Task DeleteAsync(AggregateId id);

    }
}
