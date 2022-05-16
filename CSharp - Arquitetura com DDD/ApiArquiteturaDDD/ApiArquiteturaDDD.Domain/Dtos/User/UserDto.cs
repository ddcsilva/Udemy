using System;
using System.ComponentModel.DataAnnotations;

namespace ApiArquiteturaDDD.Domain.Dtos.User
{
    public class UserDto
    {
        [Required(ErrorMessage = "Nome é um campo obrigatório para Login")]
        [StringLength(100, ErrorMessage = "Email deve ter no máximo {1} caracteres.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email é um campo obrigatório para Login")]
        [EmailAddress(ErrorMessage = "E-mail em formato inválido.")]
        [StringLength(100, ErrorMessage = "Email deve ter no máximo {1} caracteres.")]
        public string Email { get; set; }
    }
}
