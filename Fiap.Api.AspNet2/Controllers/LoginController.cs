using Fiap.Api.AspNet2.Data;
using Fiap.Api.AspNet2.Models;
using Fiap.Api.AspNet2.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;


namespace Fiap.Api.AspNet2.Controllers
{
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        public ActionResult<dynamic> Index(
            [FromBody] UsuarioModel usuarioRequest,
            [FromServices] DataContext dataContext)
        {
            var usuario = dataContext.Usuarios
                .AsNoTracking()
                .Where(u => u.NomeUsuario == usuarioRequest.NomeUsuario &&
                            u.Senha == usuarioRequest.Senha)
                .SingleOrDefault();

            if (usuario == null)
            {
                return Unauthorized();
            }

            string token = AuthenticationService.GetToken(usuario);

            var retorno = new
            {
                usuario = usuario,
                token = token
            };

            return Ok(retorno);
        }
    }
}
