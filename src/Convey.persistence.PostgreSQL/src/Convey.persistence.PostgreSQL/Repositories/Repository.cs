using Convey.Domain.Entities;
using Convey.Domain.Repository;
using Microsoft.EntityFrameworkCore;

namespace Convey.persistence.PostgreSQL.Repositories
{
    public class Repository<T, TContext> : IRepository<T> where TContext : DbContext where T : AggregateRoot
    {
        private TContext _dbContext;
        public Repository(TContext dbContext) 
        {
            this._dbContext = dbContext;
        }

        public async Task AddAsync(T resource)
        {
            await _dbContext.Set<T>().AddAsync(resource);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(AggregateId id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> ExistsAsync(AggregateId id)
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetAsync(AggregateId id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(T resource)
        {
            throw new NotImplementedException();
        }
    }
}
