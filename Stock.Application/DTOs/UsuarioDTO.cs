using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Application.DTOs
{
    public class UsuarioDTO
    {

        [Required]
        [StringLength(100)]
        public string UserNomeCompleto { get; set; }

        public string UserFotografiaPath { get; set; }

        [Required]
        [StringLength(100,MinimumLength =8, ErrorMessage = "O nome completo deve ter no minimo 8 caracter")]
        public string useremail { get; set; }

        [Required]
        [StringLength(100)]
        public string usersector { get; set; }

        [Required]
        [StringLength(100)]
        public string UserNacionalidade { get; set; }

        [Required]
        [StringLength(100)]
        public string datanascimento { get; set; }

        [Required]
        public int useridade { get; set; }

        [Required]
        [StringLength(100)]
        public string password{ get; set; }

        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}

