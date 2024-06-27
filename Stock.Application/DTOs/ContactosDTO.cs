using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Application.DTOs
{
    public class ContactosDTO
    {
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "O codigo de telefonia  deve ter no minimo 1 caracter")]
        public string usercodigopais { get; set; }

        [Required]
        [StringLength(20)]
        public string usertelefone1 { get; set; }

        [Required]
        [StringLength(20)]
        public string usertelefone2 { get; set; }

        [Required]
        [StringLength(24)]
        public string usertelefonefixo { get; set; }

        
    }
}
