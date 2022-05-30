using MonkTechWebAPI.Models.Dto.Agenda;

namespace MonkTechWebAPI.Models.Dto.Salao
{
    public class GetSalaoAgendasDto
    {
        public int Id { get; set; }
        public string Cnpj { get; set; } = null!;
        public string RazaoSocial { get; set; } = null!;
        public List<GetAgendaDto>? Agendas { get; set; }
    }
}
