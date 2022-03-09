using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Fiap.Api.AspNet2.Controllers
{

    [Route("api/[controller]")]
    [Authorize]
    public class TesteController : Controller
    {


        [AllowAnonymous]
        [Route("anonimo")]
        public string Anonimo()
        {
            return "Anonimo";
        }


        [HttpGet]
        [Authorize]
        [Route("autenticado")]
        public string Autenticado()
        {
            return "Autenticado";
        }


        [Authorize(Roles = "Junior, Pleno, Senior")]
        [Route("junior")]
        public string Junior()
        {
            return "Junior";
        }


        [Authorize(Roles = "Pleno, Senior")]
        [Route("pleno")]
        public string Pleno()
        {
            return "Pleno";
        }

        [Authorize(Roles = "Senior")]
        [Route("senior")]
        public string Senior()
        {
            return "Senior";
        }



    }
}
