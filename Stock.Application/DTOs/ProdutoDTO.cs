using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Application.DTOs
{
    public class ProdutoDTO
    {
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "O nome do produto deve ter no minimo 1 caracter")]
        public string produtonome { get; set; }

        public string produtofotografia  { get; set; }

        [Required]
        [StringLength(100)]
        public string categoria { get; set; }

        [Required]
        [StringLength(100)]
        public string tipo { get; set; }

        [Required]
        public float preco { get; set; }

        [Required]
        public float quantidade { get; set; }

        public float Total { get; set; }
    }
}
