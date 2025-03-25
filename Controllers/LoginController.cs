using ApiDanielEstudo.Dto;
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
                return CreatedAtAction("",usuario);
            }
            catch (EmailRegisterException ex)
            {
                return BadRequest(ex.Message);
                throw;
            }            
        }
    }
}
