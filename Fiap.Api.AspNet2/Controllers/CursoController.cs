using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiap.Api.AspNet2.Clients;
using Fiap.Api.AspNet2.Models;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Api.AspNet2.Controllers
{
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    [ApiVersion("3.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class CursoController : ControllerBase
    {
        private readonly CursoClient cursoClient;

        public CursoController()
        {
            cursoClient = new CursoClient();
        }


        [HttpGet]
        public async Task<ActionResult<IList<CursoModel>>> GetAllAsync(
            )
        {
            var cursos = await cursoClient.Get();

            if (cursos.Count == 0)
            {
                return NoContent();
            }

            return Ok(cursos);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<CursoModel>> GetByIdAsync([FromRoute] int id)
        {
            try {
                var curso = await cursoClient.Get(id);
                return Ok(curso);
            }
            catch
            {
                return NotFound();
            }
            
        }

        [HttpPost]
        public async Task<ActionResult<CursoModel>> PostAsync([FromBody] CursoModel cursoModel )
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                cursoModel.Id = await cursoClient.Post(cursoModel);
                var location = new Uri($"{Request.GetEncodedUrl()}/{cursoModel.Id}");
                return Created(location, cursoModel);
            }
            catch (Exception error)
            {
                return BadRequest(new { message = $"Não foi possível inserir o curso. Detalhes: {error.Message}" });
            }
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<CategoriaModel>> PutAsync(
            [FromRoute] int id,
            [FromBody] CursoModel cursoModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (cursoModel.Id != id)
            {
                return NotFound();
            }

            try
            {
                _ = cursoClient.Put(cursoModel);
                return NoContent();
            }
            catch (Exception error)
            {
                return BadRequest(new { message = $"Não foi possível alterar o curso. Detalhes: {error.Message}" });
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteAsync(
            [FromRoute] int id)
        {
            _ = cursoClient.Delete(id);

            return Ok();
        }
    }
}
