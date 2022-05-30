using Microsoft.EntityFrameworkCore;
using MonkTechWebAPI.Contracts;
using MonkTechWebAPI.Data;
using MonkTechWebAPI.Models;

namespace MonkTechWebAPI.Repositories
{
    public class SaloesRepository : GenericRepository<Salao>, ISaloesRepository
    {
        private readonly ApiDbContext _dbContext;

        public SaloesRepository(ApiDbContext dbContext) : base(dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<Salao> GetDetails(int id)
        {
            return await _dbContext.Saloes.Include(q => q.Endereco).FirstOrDefaultAsync(q => q.Id == id);
        }

        public async Task<Salao> GetDetailsAndAgendas(int id)
        {
            return await _dbContext.Saloes.Include(q => q.Agendas).FirstOrDefaultAsync(q => q.Id == id);
        }
    }
}
