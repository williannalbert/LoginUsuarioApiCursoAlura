using System.ComponentModel.DataAnnotations;

namespace LoginUsuarioApiCursoAlura.Data.DTOs
{
    public class LoginUsuarioDTO
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
