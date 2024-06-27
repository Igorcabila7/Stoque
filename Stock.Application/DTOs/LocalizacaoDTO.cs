using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Application.DTOs
{
    public class LocalizacaoDTO
    {
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "O nome do pais deve ter no minimo 1 caracter")]
        public string userpais { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "O nome da provincia deve ter no minimo 4 caracter")]
        public string userprovincia { get; set; }

        [Required]
        [StringLength(100)]
        public string usercomuna { get; set; }

        [Required]
        [StringLength(100)]
        public string userbairro { get; set; }

        [Required]
        [StringLength(100)]
        public string usernumercasa{ get; set; }

       
    }
}
