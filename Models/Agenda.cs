namespace MonkTechWebAPI.Models
{
    public class Agenda
    {
        public int Id { get; set; }
        public DateTime Dia { get; set; }
        public string HoraInicio { get; set; } = null!;
        public string HoraFim { get; set; } = null!;
        public string NomeDoCliente { get; set; } = null!;
        public string TelefoneDoCliente { get; set; } = null!;
        public bool Disponivel { get; set; }
        public int SalaoId { get; set; }
    }
}
