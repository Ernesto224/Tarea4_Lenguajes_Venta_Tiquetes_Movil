using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venta.DA.Entidades
{
    [Table("tipoZona")]
    public class TipoZonaDA
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTipoZona { get; set; }

        [Required]
        public string? nombreZona { get; set; }

        [Required]
        public decimal precioAsiento { get; set; }
    }
}
