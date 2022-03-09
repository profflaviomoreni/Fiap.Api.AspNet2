using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Fiap.Api.AspNet2.Controllers
{
    [Route("api/[controller]")]
    public class CacheController : Controller
    {

        [HttpGet]
        [Route("yes")]
        [ResponseCache(Duration = 20, Location = ResponseCacheLocation.Any, NoStore = false)]
        public ActionResult Caching()
        {
            return Ok(DateTime.Now.ToString());
        }

        [HttpGet]
        [Route("no")]
        public ActionResult NoCaching()
        {
            return Ok(DateTime.Now.ToString());
        }

    }
}
