using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiap.Api.AspNet2.Models;
using Fiap.Api.AspNet2.Repository.Interface;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Api.AspNet2.Controllers
{

    [Route("api/[controller]")]
    public class MarcaController : ControllerBase
    {

        /*
        [HttpGet]
        [Route("GetAll")]
        public ActionResult<IList<MarcaModel>> GetAll(
            [FromServices] IMarcaRepository marcaRepository)
        {
            var marca = marcaRepository.FindAll();

            if (marca.Count == 0)
            {
                return NoContent();
            }

            return Ok(marca);
        }
        */

        [HttpGet]
        [ResponseCache(Duration = 60, Location = ResponseCacheLocation.Any)]
        public ActionResult<dynamic> Get(
            [FromQuery] int pagina = 0 ,
            [FromQuery] int tamanho = 30,
            [FromServices] IMarcaRepository marcaRepository = null)
        {

            var totalGeral = marcaRepository.Count();
            var totalPaginas = (int) Math.Ceiling((double) totalGeral / tamanho);
            var anterior = pagina > 0 ? $"marca?pagina={pagina-1}&tamanho={tamanho}" : "";
            var proximo = pagina < totalPaginas - 1 ? $"marca?pagina={pagina + 1}&tamanho={tamanho}" : "";

            if ( pagina > totalPaginas  )
            {
                return NotFound();
            }


            IList<MarcaModel> marcas = marcaRepository.FindAll(pagina, tamanho);

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



        [HttpGet("{id:int}")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public ActionResult<MarcaModel> GetById(
            [FromRoute] int id,
            [FromServices] IMarcaRepository marcaRepository)
        {
            var marca = marcaRepository.FindById(id);

            if (marca == null)
            {
                return NotFound();
            }

            return Ok(marca);
        }

        [HttpPost]
        public ActionResult<MarcaModel> Post(
            [FromServices] IMarcaRepository marcaRepository,
            [FromBody] MarcaModel marcaModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var marcaId = marcaRepository.Insert(marcaModel);
                marcaModel.MarcaId = marcaId;

                var location = new Uri(Request.GetEncodedUrl() + marcaId);

                return Created(location, marcaModel);
            }
            catch (Exception error)
            {
                return BadRequest(new { message = $"Não foi possível inserir a marca. Detalhes: {error.Message}" });
            }
        }


        [HttpPut("{id:int}")]
        public ActionResult<MarcaModel> Put(
            [FromRoute] int id,
            [FromServices] IMarcaRepository marcaRepository,
            [FromBody] MarcaModel marcaModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (marcaModel.MarcaId != id)
            {
                return NotFound();
            }

            try
            {
                marcaRepository.Update(marcaModel);

                return Ok(marcaModel);
            }
            catch (Exception error)
            {
                return BadRequest(new { message = $"Não foi possível alterar a marca. Detalhes: {error.Message}" });
            }
        }


        [HttpDelete("{id:int}")]
        public ActionResult<MarcaModel> Delete(
             [FromRoute] int id,
             [FromServices] IMarcaRepository marcaRepository)
        {
            marcaRepository.Delete(id);

            return Ok();
        }



    }
}
