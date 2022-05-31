namespace MonkTechWebAPI.Models
{
    public class Agenda
    {
        public int Id { get; set; }
        public DateTime Dia { get; set; }
        public string HoraInicio { get; set; } = null!;
        public string HoraFim { get; set; } = null!;
        public string? NomeDoCliente { get; set; }
        public string? TelefoneDoCliente { get; set; }
        public bool Disponivel { get; set; } = true;
        public int SalaoId { get; set; }
    }
}
