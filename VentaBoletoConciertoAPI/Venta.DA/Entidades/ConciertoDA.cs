using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventan.DA.Entidades
{
    [Table("Concierto")]
    public class ConciertoDA
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idConcierto { get; set; }

        [Required]
        public string? imagenArtista { get; set; }

        [Required]
        public string? nombreArtista { get; set; }

        [Required]
        public DateTime fechaEvento { get; set; }

        [Required]
        public string? ubicacionConcierto { get; set; }
    }
}
