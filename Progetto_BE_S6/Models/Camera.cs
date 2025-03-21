﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Progetto_BE_S6.Models
{
    public class Camera
    {
        [Key]
        public Guid CameraId { get; set; }

        [Required]
        public required string Numero { get; set; }
        [Required]
        [AllowedValues("Singola", "Doppia", "Tripla", "Quadrupla")]
        public required string Tipo { get; set; }

        [Required]
        [Column(TypeName ="decimal(9,2)")]
        public required decimal Prezzo { get; set; }

        [Required]
        public bool IsDisponibile { get; set; }


        public ICollection<Prenotazione> Prenotazione { get; set; }
    }
}
