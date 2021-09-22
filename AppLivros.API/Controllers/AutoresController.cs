using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AppLivros.API.Context;
using AppLivros.API.Models;
using AppLivros.API.Services;

namespace AppLivros.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutoresController : ControllerBase
    {
        private IAutorService _autorService;

        public AutoresController(IAutorService autorService)
        {
            _autorService = autorService;
        }

        // GET: api/Autores
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IAsyncEnumerable<Autor>>> ExibirAutores()
        {
            try
            {
                var alunos = await _autorService.ExibirAutores();
                return Ok(alunos);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro: autores não encontrados");
            }
        }

        [HttpGet("AutorPorNome")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IAsyncEnumerable<Autor>>> ObterAutorPeloNome([FromQuery] string nome)
        {
            try
            {
                var autores = await _autorService.ObterAutorPeloNome(nome);
                if (!autores.Any())
                    return NotFound($"Não existe autor com esse critério {nome}");
                //return Ok(await _autorService.Autores.ToListAsync());
                return Ok(autores);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro: autor não encontrados");
            }
        }

        // GET: api/Autores/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<Autor>> GetAutor(Guid id)
        {
            try
            {
                var autor = await _autorService.DetalhesAutor(id);

                if (autor == null)
                    return NotFound($"Erro: {id} não encontrado");

                return Ok(autor);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro: verificar");
            }
            
        }

        // POST: api/Autores
        [HttpPost]
        public async Task<ActionResult> CriarAutor(Autor autor)
        {
            try
            {
                await _autorService.CadastrarAutor(autor);
                //return CreatedAtRoute(nameof(GetAutor), new { id = autor.Id }, autor);
                return Ok();
            }
            catch
            {
                return BadRequest("Request inválido!");
            }
        }

        // PUT: api/Autores/5
        [HttpPut("{id}")]
        public async Task<ActionResult> EditarAutor(Guid id, [FromBody] Autor autor)
        {
            try
            {
               if(autor.Id == id)
               {
                    await _autorService.EditarAutor(autor);
                    return Ok($"Autor com id={id} foi atualizado!");
                    //return NoContent();
               }
               else
               {
                    return BadRequest("Dados inconsistentes!");
               }
            }
            catch
            {
                return BadRequest("Request inválido!");
            }
        }

        // DELETE: api/Autores/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {

            try
            {
                var autor = await _autorService.DetalhesAutor(id);
                if (autor != null)
                {
                    await _autorService.DeletarAutor(autor);
                    return Ok($"Autor com id={id} foi excluído!");
                    //return NoContent();
                }
                else
                {
                    return NotFound("Dados inconsistentes!");
                }
            }
            catch
            {
                return BadRequest("Request inválido!");
            }
        }

    }
}
