using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventan.DA.Entidades;

namespace Venta.DA.Entidades
{
    [Table("asiento")]
    public class AsientoDA
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idAsiento { get; set; }

        [Required]
        public string? codigoAsiento { get; set; }

        [Required]
        public int idTipoZona { get; set; }

        [ForeignKey("idTipoZona")]
        public TipoZonaDA? TipoZona { get; set; }

        [Required]
        public int idConcierto { get; set; }

        [ForeignKey("idConcierto")]
        public ConciertoDA? Concierto { get; set;}

        [Required]
        public bool reservado { get; set; } = false;

    }
}
