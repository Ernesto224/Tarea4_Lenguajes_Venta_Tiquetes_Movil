using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venta.DA.Entidades
{
    [Table("TipoZona")]
    public class TipoZonaDA
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idTipoZona { get; set; }

        [Required]
        public string? nombreZona { get; set; }

        [Required]
        public decimal precioAsiento { get; set; }
    }
}
