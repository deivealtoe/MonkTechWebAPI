using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using MonkTechWebAPI.Contracts;
using MonkTechWebAPI.Models;
using MonkTechWebAPI.Models.Dto.Usuario;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MonkTechWebAPI.Repositories
{
    public class AuthManager : IAuthManager
    {
        private readonly IMapper _mapper;
        private readonly UserManager<Usuario> _userManager;
        private readonly IConfiguration _configuration;

        public AuthManager(IMapper mapper, UserManager<Usuario> userManager, IConfiguration configuration)
        {
            this._mapper = mapper;
            this._userManager = userManager;
            this._configuration = configuration;
        }

        public async Task<IEnumerable<IdentityError>> Register(UsuarioDto usuarioDto)
        {
            var usuario = _mapper.Map<Usuario>(usuarioDto);
            usuario.UserName = usuarioDto.Email;

            var resultado = await _userManager.CreateAsync(usuario, usuarioDto.Password);

            throw new NotImplementedException();
        }

        public async Task<AuthResponseDto> Login(UsuarioLoginDto usuarioLoginDto)
        {
            var usuario = await _userManager.FindByEmailAsync(usuarioLoginDto.Email);
            bool usuarioEhValido = await _userManager.CheckPasswordAsync(usuario, usuarioLoginDto.Password);

            if (usuarioEhValido)
            {
                var token = await GenerateToken(usuario);

                return new AuthResponseDto
                {
                    Token = token,
                    UserId = usuario.Id
                };
            }

            return null!;
        }

        private async Task<string> GenerateToken(Usuario usuario)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSettings:Key"]));

            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var roles = await _userManager.GetRolesAsync(usuario);

            var rolesClaims = roles.Select(x => new Claim(ClaimTypes.Role, x)).ToList();
            var userClaims = await _userManager.GetClaimsAsync(usuario);

            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, usuario.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email, usuario.Email),
            }.Union(userClaims).Union(rolesClaims);

            var token = new JwtSecurityToken(
                issuer: _configuration["JwtSettings:Issuer"],
                audience: _configuration["JwtSettings:Audience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(Convert.ToInt32(_configuration["JwtSettings:DurationInMinutes"])),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
