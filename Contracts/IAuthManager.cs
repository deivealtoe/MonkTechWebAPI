using Microsoft.AspNetCore.Identity;
using MonkTechWebAPI.Models.Dto.Usuario;

namespace MonkTechWebAPI.Contracts
{
    public interface IAuthManager
    {
        public Task<IEnumerable<IdentityError>> Register(UsuarioDto usuarioDto);
        public Task<AuthResponseDto> Login(UsuarioLoginDto usuarioLoginDto);
    }
}
