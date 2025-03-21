using System.ComponentModel.DataAnnotations;

namespace Progetto_BE_S6.ViewModel
{
    public class LoginViewModel
    {
        [Required]
        public required string Email { get; set; }
        [Required]
        public required string Password { get; set; }
    }
}
