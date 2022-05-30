using MonkTechWebAPI.Models;

namespace MonkTechWebAPI.Contracts
{
    public interface ISaloesRepository : IGenericRepository<Salao>
    {
        Task<Salao> GetDetails(int id);
        Task<Salao> GetDetailsAndAgendas(int id);
    }
}
