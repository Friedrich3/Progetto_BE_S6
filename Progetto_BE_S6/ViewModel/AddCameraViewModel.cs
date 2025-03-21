using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Progetto_BE_S6.ViewModel
{


    public class AddCameraViewModel
    {
     

        [Required]
        public required Guid CameraId { get; set; }

        [Required]
        [StringLength(3)]
        [RegularExpression("^[0-9]+$")]
        public required string Numero { get; set; }
        [Required]
        [AllowedValues("Singola", "Doppia", "Tripla", "Quadrupla")]
        public required string Tipo { get; set; }

        [Required]
        [Column(TypeName = "decimal(9,2)")]
        public required decimal Prezzo { get; set; }

        [Required]
        public bool IsDisponibile { get; set; }
       
        }
}

