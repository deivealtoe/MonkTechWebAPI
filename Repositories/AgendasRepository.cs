using Microsoft.EntityFrameworkCore;
using MonkTechWebAPI.Configurations;
using MonkTechWebAPI.Contracts;
using MonkTechWebAPI.Models;
using MonkTechWebAPI.Models.Dto.Agenda;

namespace MonkTechWebAPI.Repositories
{
    public class AgendasRepository : GenericRepository<Agenda>, IAgendasRepository
    {
        private readonly ApiDbContext _dbContext;

        public AgendasRepository(ApiDbContext dbContext) : base(dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<List<Agenda>> GetAgendasDeUmSalao(int idDoSalao)
        {
            return await _dbContext.Agendas.Where(w => w.SalaoId == idDoSalao).ToListAsync();
        }

        public async Task<List<Agenda>> GetAgendasDisponiveisDeUmSalao(int idDoSalao)
        {
            return await _dbContext.Agendas.Where(w => w.SalaoId == idDoSalao && w.Disponivel == true).ToListAsync();
        }

        public async Task<Agenda> MarcarAgenda(int idDaAgenda, PutAgendaDto putAgendadto)
        {
            var agenda = await _dbContext.Agendas.FindAsync(idDaAgenda);

            if (agenda != null)
            {
                agenda.Disponivel = false;
                agenda.NomeDoCliente = putAgendadto.NomeDoCliente;
                agenda.TelefoneDoCliente = putAgendadto.TelefoneDoCliente;

                _dbContext.Agendas.Update(agenda);
                await _dbContext.SaveChangesAsync();

                return agenda;
            }

            return null;
        }
    }
}
