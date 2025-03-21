using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Progetto_BE_S6.Models
{
    public class Prenotazione
    {
        [Key]
        public Guid PrenotazioneId { get; set; }

        [Required]
        public Guid ClienteId { get; set; }
        [Required]
        public Guid CameraId { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DataInizio { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DataFine { get; set; }
        [Required]
        [AllowedValues("confirmed","checkedin", "instay", "checkedout")]
        public string Stato { get; set; }
        [Required]
        public string CreatedBy { get; set; }


        [ForeignKey("ClienteId")]
        public Cliente Cliente { get; set; }

        [ForeignKey("CameraId")]
        public Camera Camera { get; set; }

    }
}
