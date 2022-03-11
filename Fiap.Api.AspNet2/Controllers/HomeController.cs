using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;


namespace Fiap.Api.AspNet2.Controllers
{
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    [ApiVersion("3.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Get - Olá Fiap - Flavio Azure";
        }

        [HttpPost]
        public string Post()
        {
            return "Post";
        }

        [HttpPut]
        public string Put()
        {
            return "Put";
        }

        [HttpDelete]
        public string Delete()
        {
            return "Delete";
        }

    }
}
