using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppLivros.API.Models
{
    public class Autor
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(40)]
        public string Nome { get; set; }

        [Required]
        [StringLength(40)]
        public string UltimoNome { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(80)]
        public string Email { get; set; }

        [Required]
        public DateTime Nascimento { get; set; }

        public List<Livro> Livros { get; set; }
    }
}
