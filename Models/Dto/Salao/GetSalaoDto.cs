namespace MonkTechWebAPI.Models.Dto.Salao
{
    public class GetSalaoDto
    {
        public int Id { get; set; }
        public string Cnpj { get; set; } = null!;
        public string RazaoSocial { get; set; } = null!;
    }
}
