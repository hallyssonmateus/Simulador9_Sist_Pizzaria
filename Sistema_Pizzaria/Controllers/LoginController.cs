using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sistema_Pizzaria.Services;
using Sistema_Pizzaria.usuario;

namespace Sistema_Pizzaria.Controllers
{
    [Route("api/Login")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        [HttpPost]
        public IActionResult Login([FromBody] UsuarioRequest usuarioRequest)
        {
            var usuario = UsuarioRepository.Get(usuarioRequest.nome, usuarioRequest.senha);
            if(usuario == null)
            {
                return NotFound(new { message = "Usuário ou senha inválidos" });
            }

            var token = TokenService.GenerateToken(usuario);
            usuario.Senha = "";

            return Ok(new
            {
                usuario = usuario,
                token = token
            });
        }
    }
}
