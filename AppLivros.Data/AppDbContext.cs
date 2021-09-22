using AppLivros.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLivros.API.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Autor> Autores { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public Guid NewGuid { get; private set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var date1 = new DateTime(2008, 5, 1, 8, 30, 52);
            modelBuilder.Entity<Autor>()
                .HasData(
                    new Autor { Id = Guid.NewGuid(), Nome = "Rafael", UltimoNome = "Silva", Email = "rafa@gmail.com", Nascimento = date1 },
                    new Autor { Id = Guid.NewGuid(), Nome = "Rafaaa", UltimoNome = "Silva", Email = "rafa@gmail.com", Nascimento = date1 },
                    new Autor { Id = Guid.NewGuid(), Nome = "Leafar", UltimoNome = "Silva", Email = "rafa@gmail.com", Nascimento = date1 }
                );

            modelBuilder.Entity<Livro>()
                .HasData(
                    new Livro { Id = Guid.NewGuid(), Titulo = "C# é legal", ISBN = "8535902775", Ano = 2000 },
                    new Livro { Id = Guid.NewGuid(), Titulo = ".NET é legal", ISBN = "8535902775", Ano = 1997 },
                    new Livro { Id = Guid.NewGuid(), Titulo = "SQL Server é legal", ISBN = "8535902775", Ano = 1998 }
                );
        }
    }
}
