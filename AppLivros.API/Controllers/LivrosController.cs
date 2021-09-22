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
    public class LivrosController : ControllerBase
    {
        private ILivroService _livroService;

        public LivrosController(ILivroService livroService)
        {
            _livroService = livroService;
        }

        // GET: api/Livros
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IAsyncEnumerable<Livro>>> GetLivros()
        {
            var livros = await _livroService.ExibirLivros();
            return Ok(livros);
        }

        [HttpGet("LivroTitulo")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IAsyncEnumerable<Livro>>> GetBookByName([FromQuery] string titulo)
        {
            var livros = await _livroService.ObterLivroPeloTitulo(titulo);
            if (!livros.Any())
                return NotFound($"Não existe livro com esse critério {titulo}");
            //return Ok(await _autorService.Autores.ToListAsync());
            return Ok(livros);
        }

        // GET: api/Livros/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<Livro>> GetLivro(Guid id)
        {
            try
            {
                var livro = await _livroService.DetalhesLivro(id);

                if (livro == null)
                    return NotFound($"Erro: {id} não encontrado");

                return Ok(livro);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro: verificar");
            }
        }

        // POST: api/Livros
        [HttpPost]
        public async Task<ActionResult> CriarLivro(Livro livro)
        {
            try
            {
                await _livroService.CadastrarLivro(livro);
                //return CreatedAtRoute(nameof(GetLivro), new { id = livro.Id }, livro);
                return Ok();
            }
            catch
            {
                return BadRequest("Request inválido!");
            }
        }

        // PUT: api/Livros/5
        [HttpPut("{id}")]
        public async Task<ActionResult> EditarLivro(Guid id, [FromBody] Livro livro)
        {
            try
            {
                if (livro.Id == id)
                {
                    await _livroService.EditarLivro(livro);
                    return Ok($"Livro com id={id} foi atualizado!");
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

        // DELETE: api/Livros/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {

            try
            {
                var livro = await _livroService.DetalhesLivro(id);
                if (livro != null)
                {
                    await _livroService.DeletarLivro(livro);
                    return Ok($"Livro com id={id} foi excluído!");
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
