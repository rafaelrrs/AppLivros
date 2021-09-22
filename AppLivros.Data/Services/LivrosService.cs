using AppLivros.API.Context;
using AppLivros.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLivros.API.Services
{
    public class LivrosService : ILivroService
    {
        private readonly AppDbContext _context;

        public LivrosService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Livro>> ExibirLivros()
        {
            try
            {
                return await _context.Livros.ToListAsync();
            }
            catch
            {
                throw;
            }
        }

        public async Task<IEnumerable<Livro>> ObterLivroPeloTitulo(string titulo)
        {
            IEnumerable<Livro> livros;

            if (!string.IsNullOrWhiteSpace(titulo))
                livros = await _context.Livros.Where(t => t.Titulo.Contains(titulo)).ToArrayAsync();
            else
                livros = await ExibirLivros();

            return livros;
        }

        public async Task<Livro> DetalhesLivro(Guid id)
        {
            try
            {
                var livros = await _context.Livros.FindAsync(id);
                return livros;
            }
            catch
            {
                throw;
            }
        }

        public async Task CadastrarLivro(Livro livro)
        {
            _context.Livros.Add(livro);
            await _context.SaveChangesAsync();
        }

        public async Task EditarLivro(Livro livro)
        {
            _context.Entry(livro).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeletarLivro(Livro livro)
        {
            _context.Livros.Remove(livro);
            await _context.SaveChangesAsync();
        }
    }
}
