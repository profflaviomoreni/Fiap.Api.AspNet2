using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiap.Api.AspNet2.Data;
using Fiap.Api.AspNet2.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Api.AspNet2.Controllers
{

    [Route("api/[controller]")]
    public class MarcaController : ControllerBase
    {

        
        private readonly DataContext dataContext;

        public MarcaController([FromServices] DataContext ctx)
        {
            dataContext = ctx;
        }
        

        /*
        [HttpGet]
        public async Task<ActionResult<IList<MarcaModel>>> Get()
        {

            List<MarcaModel> marcas = await dataContext.Marcas.AsNoTracking().ToListAsync<MarcaModel>();

            return Ok(marcas);

        }
        */


        [HttpGet]
        [ResponseCache(Duration = 60, Location = ResponseCacheLocation.Any)]
        public async Task<ActionResult<dynamic>> Get(
            [FromQuery] int pagina = 0 ,
            [FromQuery] int tamanho = 30 )
        {

            var totalGeral = await dataContext.Marcas.CountAsync();
            var totalPaginas = (int) Math.Ceiling((double) totalGeral / tamanho);
            var anterior = pagina > 0 ? $"marca?pagina={pagina-1}&tamanho={tamanho}" : "";
            var proximo = pagina < totalPaginas - 1 ? $"marca?pagina={pagina + 1}&tamanho={tamanho}" : "";

            if ( pagina > totalPaginas  )
            {
                return NotFound();
            }


            List<MarcaModel> marcas =
                await dataContext.Marcas
                    .Skip(tamanho * pagina)
                    .Take(tamanho)
                    .AsNoTracking()
                    .ToListAsync();

            return Ok(
                new
                {
                    Total = totalGeral,
                    TotalPaginas = totalPaginas,
                    AnteriorLink = anterior,
                    ProximoLink = proximo,
                    Marcas = marcas
                }
             );

        }



        [HttpGet("{id}")]
        public async Task<ActionResult<MarcaModel>> Get(int id)
        {
            var marca = await dataContext.Marcas.AsNoTracking().FirstOrDefaultAsync(m => m.MarcaId == id);

            if (marca != null)
            {
                return Ok(marca);
            } else
            {
                return NotFound();
            }

        }

        [HttpPost]
        public async Task<ActionResult<MarcaModel>> Post([FromBody] MarcaModel marcaModel)
        {

            if ( ! ModelState.IsValid )
            {
                return BadRequest(ModelState);
            }

            try { 
                dataContext.Marcas.Add(marcaModel);
                await dataContext.SaveChangesAsync();

                var location = new Uri(Request.GetEncodedUrl() + marcaModel.MarcaId);
                return Created(location,marcaModel);
            } catch
            {
                return BadRequest(new { message = "Não foi possível inserir a marca" } );
            }
        }


        [HttpPut("{id:int}")]
        public async Task<ActionResult<MarcaModel>> Put(
            [FromRoute] int id,
            [FromBody] MarcaModel marcaModel)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if ( marcaModel.MarcaId != id )
            {
                return NotFound();
            }

            try
            {
                dataContext.Marcas.Update(marcaModel);
                await dataContext.SaveChangesAsync();

                return NoContent();
            }
            catch
            {
                return BadRequest(new { message = "Não foi possível atualizar a marca" });
            }
        }


        [HttpDelete("{id:int}")]
        public async Task<ActionResult<MarcaModel>> Delete([FromRoute] int id)
        {

            if ( 0 == id)
            {
                return BadRequest();
            }

            try
            {
                var marca = await dataContext.Marcas.FindAsync(id);

                if ( marca != null)
                {
                    dataContext.Marcas.Remove(marca);
                    await dataContext.SaveChangesAsync();

                    return NoContent();
                } else
                {
                    return NotFound();
                }

            }
            catch
            {
                return BadRequest(new { message = "Não foi possível remover a marca" });
            }
        }


    }
}
