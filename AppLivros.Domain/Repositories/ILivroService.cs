using AppLivros.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLivros.API.Services
{
    public interface ILivroService
    {
        Task<IEnumerable<Livro>> ExibirLivros();
        Task<Livro> DetalhesLivro(Guid id);
        Task<IEnumerable<Livro>> ObterLivroPeloTitulo(string titulo);
        Task CadastrarLivro(Livro livro);
        Task EditarLivro(Livro livro);
        Task DeletarLivro(Livro livro);
    }
}
