using AppLivros.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLivros.API.Services
{
    public interface IAutorService
    {
        Task<IEnumerable<Autor>> ExibirAutores();
        Task<Autor> DetalhesAutor(Guid id);
        Task<IEnumerable<Autor>> ObterAutorPeloNome(string nome);
        Task CadastrarAutor(Autor autor);
        Task EditarAutor(Autor autor);
        Task DeletarAutor(Autor autor);
    }
}
