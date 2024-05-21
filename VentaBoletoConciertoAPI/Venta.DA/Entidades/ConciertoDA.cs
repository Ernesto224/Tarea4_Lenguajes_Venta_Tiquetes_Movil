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
        public int IdConcierto { get; set; }

        [Required]
        public string ImagenArtista { get; set; }

        [Required]
        public string NombreArtista { get; set; }

        [Required]
        public DateTime FechaEvento { get; set; }

        [Required]
        public string UbicacionConcierto { get; set; }
    }
}
