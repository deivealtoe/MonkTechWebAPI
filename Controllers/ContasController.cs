using Microsoft.AspNetCore.Mvc;
using MonkTechWebAPI.Contracts;
using MonkTechWebAPI.Models.Dto.Usuario;

namespace MonkTechWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContasController : ControllerBase
    {
        private readonly IAuthManager _authManager;

        public ContasController(IAuthManager authManager)
        {
            this._authManager = authManager;
        }

        // /api/Contas/Register
        [HttpPost]
        [Route("Register")]
        public async Task<ActionResult> Register(UsuarioDto usuarioDto)
        {
            var errors = await _authManager.Register(usuarioDto);

            if (errors.Any())
            {
                foreach (var error in errors)
                {
                    ModelState.AddModelError(error.Code, error.Description);
                }

                return BadRequest(ModelState);
            }

            return Ok();
        }

        [HttpPost]
        [Route("Login")]
        public async Task<ActionResult<AuthResponseDto>> Login(UsuarioLoginDto usuarioLoginDto)
        {
            var authResponse = await _authManager.Login(usuarioLoginDto);

            if (authResponse != null)
            {
                return Ok(authResponse);
            }

            return Unauthorized();
        }
    }
}
