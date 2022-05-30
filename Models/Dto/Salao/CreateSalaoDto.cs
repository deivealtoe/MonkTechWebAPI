namespace MonkTechWebAPI.Models.Dto.Salao
{
    public class CreateSalaoDto
    {
        public string Cnpj { get; set; } = null!;
        public string RazaoSocial { get; set; } = null!;
        public string? Pais { get; set; }
        public string Estado { get; set; } = null!;
        public string Cidade { get; set; } = null!;
        public string Bairro { get; set; } = null!;
        public string Rua { get; set; } = null!;
        public string? Numero { get; set; }
        public string Cep { get; set; } = null!;
    }
}
