using MonkTechWebAPI.Configurations;
using MonkTechWebAPI.Contracts;
using MonkTechWebAPI.Models;

namespace MonkTechWebAPI.Repositories
{
    public class EnderecosRepository : GenericRepository<Endereco>, IEnderecosRepository
    {
        public EnderecosRepository(ApiDbContext dbContext) : base(dbContext)
        {
        }
    }
}
