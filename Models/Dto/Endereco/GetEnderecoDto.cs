namespace MonkTechWebAPI.Models.Dto.Endereco
{
    public class GetEnderecoDto
    {
        public int Id { get; set; }
        public string? Pais { get; set; }
        public string Estado { get; set; } = null!;
        public string Cidade { get; set; } = null!;
        public string Bairro { get; set; } = null!;
        public string Rua { get; set; } = null!;
        public string? Numero { get; set; }
        public string Cep { get; set; } = null!;
    }
}
