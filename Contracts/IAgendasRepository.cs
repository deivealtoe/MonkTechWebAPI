using MonkTechWebAPI.Models;
using MonkTechWebAPI.Models.Dto.Agenda;

namespace MonkTechWebAPI.Contracts
{
    public interface IAgendasRepository : IGenericRepository<Agenda>
    {
        Task<List<Agenda>> GetAgendasDeUmSalao(int idDoSalao);
        Task<Agenda> MarcarAgenda(int idDaAgenda, PutAgendaDto putAgendaDto);
    }
}
