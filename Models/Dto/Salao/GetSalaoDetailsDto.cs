using MonkTechWebAPI.Models.Dto.Agenda;
using MonkTechWebAPI.Models.Dto.Endereco;

namespace MonkTechWebAPI.Models.Dto.Salao
{
    public class GetSalaoDetailsDto
    {
        public int Id { get; set; }
        public string Cnpj { get; set; } = null!;
        public string RazaoSocial { get; set; } = null!;
        public GetEnderecoDto? Endereco { get; set; }
    }
}
