namespace MonkTechWebAPI.Models
{
    public class Salao
    {
        public int Id { get; set; }
        public string Cnpj { get; set; } = null!;
        public string RazaoSocial { get; set; } = null!;
        public Endereco? Endereco { get; set; }
        public List<Agenda>? Agendas { get; set; }
        public Usuario Usuario { get; set; } = null!;
    }
}
