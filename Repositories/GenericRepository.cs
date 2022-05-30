using Microsoft.EntityFrameworkCore;
using MonkTechWebAPI.Contracts;
using MonkTechWebAPI.Data;

namespace MonkTechWebAPI.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApiDbContext _dbContext;

        public GenericRepository(ApiDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _dbContext.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetAsync(id);
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<bool> Exists(int id)
        {
            var entity = await GetAsync(id);
            return entity != null;
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetAsync(int id)
        {
            var entity = await _dbContext.Set<T>().FindAsync(id);

            if (entity != null)
            {
                return entity;
            }

            return null;
        }

        public async Task UpdateAsync(T entity)
        {
            _dbContext.Update(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}