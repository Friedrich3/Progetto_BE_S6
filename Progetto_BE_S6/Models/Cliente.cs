using System.ComponentModel.DataAnnotations;

namespace Progetto_BE_S6.Models
{
    public class Cliente
    {
        [Key]
        public Guid ClienteId { get; set; }

        [Required]
        [StringLength(50)]
        public required string Nome { get; set; }

       [Required]
       [StringLength(50)]
       public required string Cognome { get; set; }

        [Required]
        [EmailAddress]
        public required string Email { get; set; }

        [Required]
        public required int Telefono {  get; set; }
        

        public ICollection<Prenotazione> Prenotazione { get; set; }


    }
}
