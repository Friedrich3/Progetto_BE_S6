using Progetto_BE_S6.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Progetto_BE_S6.ViewModel
{
    public class AddPrenotazioneViewModel
    {
        
        //[Required]
        //public required Guid ClienteId { get; set; }
        [Required]
        public required Guid CameraId { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public required DateTime DataInizio { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public required DateTime DataFine { get; set; }

        [Required]
        public required string Nome { get; set; }

        [Required]
        [StringLength(50)]
        public required string Cognome { get; set; }

        [Required]
        [EmailAddress]

        public required string Email { get; set; }

        [Required]
        public required string Telefono { get; set; }









        //[Required]
        //[AllowedValues("pending", "confirmed", "instay", "checkedout")]
        //public required string Stato { get; set; }
        //[Required]
        //public required string CreatedBy { get; set; }
        //[ForeignKey("ClienteId")]
        //public Cliente Cliente { get; set; }
        //[ForeignKey("CameraId")]
        //public Camera Camera { get; set; }
    }
}
