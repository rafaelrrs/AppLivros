using AppLivros.API.Context;
using AppLivros.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLivros.API.Services
{
    public class AutoresService : IAutorService
    {
        private readonly AppDbContext _context;

        public AutoresService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Autor>> ExibirAutores()
        {
            try
            {
                return await _context.Autores.ToListAsync();
            }
            catch
            {
                throw;
            }
        }

        public async Task<IEnumerable<Autor>> ObterAutorPeloNome(string nome)
        {
            IEnumerable<Autor> autores;

            if (!string.IsNullOrWhiteSpace(nome))
                autores = await _context.Autores.Where(n => n.Nome.Contains(nome)).ToArrayAsync();
            else
                autores = await ExibirAutores();
            
            return autores;
        }

        public async Task<Autor> DetalhesAutor(Guid id)
        {
            try
            {
                var autores = await _context.Autores.FindAsync(id);
                return autores;
            }
            catch
            {
                throw;
            }
        }

        public async Task CadastrarAutor(Autor autor)
        {
            _context.Autores.Add(autor);
            await _context.SaveChangesAsync();
        }

        public async Task EditarAutor(Autor autor)
        {
            _context.Entry(autor).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeletarAutor(Autor autor)
        {
            _context.Autores.Remove(autor);
            await _context.SaveChangesAsync();
        }
    }
}
