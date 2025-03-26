using ApiDanielEstudo.Dto.Login;
using ApiDanielEstudo.Dto.Usuario;
using ApiDanielEstudo.Exceptions;
using ApiDanielEstudo.Services.Usuario;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiDanielEstudo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IUsuarioInterface _usuarioInterface;

        public LoginController(IUsuarioInterface usuarioInterface)
        {
            _usuarioInterface = usuarioInterface;
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegistrarUsuario(UsuarioCriacaoDto usuarioCriacaoDto)
        {
            try
            {
                var usuario = await _usuarioInterface.RegistrarUsuario(usuarioCriacaoDto);
                return Ok(usuario);

                //return CreatedAtAction("", usuario);
            }
            catch (EmailRegisterException ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }


        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {

            var usuario = await _usuarioInterface.Login(loginDto);
            return Ok(usuario);
            //return CreatedAtAction("", usuario);
        }
    }
}
