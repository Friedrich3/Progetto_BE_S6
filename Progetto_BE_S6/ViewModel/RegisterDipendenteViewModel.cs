using System.ComponentModel.DataAnnotations;

namespace Progetto_BE_S6.ViewModel
{
    public class RegisterDipendenteViewModel
    {
        [Required]
        public required string FirstName { get; set; }
        [Required]
        public required string LastName { get; set; }
        [Required]
        [EmailAddress]
        public required string Email { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public required DateOnly BirthDate { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 8)]
        public required string Password { get; set; }
        [Compare("Password")]
        [StringLength(60, MinimumLength = 8)]
        public required string ConfermaPassword { get; set; }

        [Required]
        public required string Role { get; set; }
    }
}
