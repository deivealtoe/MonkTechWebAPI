using System.ComponentModel.DataAnnotations;

namespace MonkTechWebAPI.Models.Dto.Usuario
{
    public class UsuarioDto
    {
        [EmailAddress]
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
