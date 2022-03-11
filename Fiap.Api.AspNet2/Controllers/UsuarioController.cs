using System.Linq;
using Fiap.Api.AspNet2.Data;
using Fiap.Api.AspNet2.Models;
using Fiap.Api.AspNet2.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Api.AspNet2.Controllers
{
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    [ApiVersion("3.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpPost]
        public ActionResult<dynamic> Index(
            [FromBody] UsuarioModel usuarioModel,
            [FromServices] DataContext dataContext
            )
        {

            var usuario = dataContext.Usuarios
                .AsNoTracking()
                .Where(u => u.NomeUsuario == usuarioModel.NomeUsuario &&
                            u.Senha == usuarioModel.Senha)
                .SingleOrDefault();


            if ( usuario == null )
            {
                return Unauthorized();
            }
            else
            {
                string token = AuthenticationService.GetToken(usuarioModel);

                usuario.Senha = "";
                var retorno = new
                {
                    usuario,
                    token
                };

                return Ok(retorno);

            }




            
        }
    }
}
