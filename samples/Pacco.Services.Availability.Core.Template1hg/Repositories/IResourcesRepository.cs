using Pacco.Services.Availability.Core.Template1hg.Entities;
using System.Threading.Tasks;

namespace Pacco.Services.Availability.Core.Template1hg.Repositories
{
    public interface IResourcesRepository
    {
        Task<Resource> GetAsync(AggregateId id);
        Task<bool> ExistsAsync(AggregateId id);
        Task AddAsync(Resource resource);
        Task UpdateAsync(Resource resource);
        Task DeleteAsync(AggregateId id);
    }
}