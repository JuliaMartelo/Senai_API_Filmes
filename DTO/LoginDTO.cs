using System.ComponentModel.DataAnnotations;

namespace api_filmes_senai.DTO
{
    public class LoginDTO
    {

        [Required(ErrorMessage = "O email e obrigatorio!")]

        public string? Email { get; set; }

        [Required(ErrorMessage = "A senha é obrigatória!")]
        [StringLength(60, MinimumLength = 6, ErrorMessage = "A senha deve ter de 6 a 60 caracteres.")]
        public string? Senha { get; set; }
    }
}

