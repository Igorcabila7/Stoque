using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Application.DTOs
{
    public class MovimentoStockDTO
    {
        [Key]
        public int id { get; set; }

        [Required]
        
        public DateTime Data { get; set; }


        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome completo deve ter no minimo 3 caracter.'Tirar','Colocar','Adicionar','Remover','Debitar','Creditar'")]
        public string movimento { get; set; }

        [Required]

        public int produtoid { get; set; }
    }
}
