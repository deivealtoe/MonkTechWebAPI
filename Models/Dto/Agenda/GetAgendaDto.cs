namespace MonkTechWebAPI.Models.Dto.Agenda
{
    public class GetAgendaDto
    {
        public int Id { get; set; }
        public DateTime Dia { get; set; }
        public string HoraInicio { get; set; } = null!;
        public string HoraFim { get; set; } = null!;
        public string NomeDoCliente { get; set; } = null!;
        public string TelefoneDoCliente { get; set; } = null!;
        public bool Disponivel { get; set; }
    }
}
