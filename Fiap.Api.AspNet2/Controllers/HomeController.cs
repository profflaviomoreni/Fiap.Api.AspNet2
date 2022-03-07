using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;


namespace Fiap.Api.AspNet2.Controllers
{
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id:int}")]
        public string Get(int id)
        {
            return $"value {id}";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id:int}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id:int}")]
        public void Delete(int id)
        {
        }
    }
}
