using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AppLivros.API.Models
{
    public class Livro
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Titulo { get; set; }

        [Required]
        [StringLength(40)]
        public string ISBN { get; set; }

        [Required]
        public int Ano { get; set; }

        public List<Autor> Autores { get; set; }
    }
}