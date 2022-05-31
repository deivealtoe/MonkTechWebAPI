namespace MonkTechWebAPI.Models.Dto.Agenda
{
    public class CreateAgendaDto
    {
        public DateTime Dia { get; set; }
        public string HoraInicio { get; set; } = null!;
        public string HoraFim { get; set; } = null!;
        public int SalaoId { get; set; }
    }
}
