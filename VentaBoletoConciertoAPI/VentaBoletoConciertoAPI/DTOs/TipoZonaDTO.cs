using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venta.DA.Entidades
{
    public class TipoZonaDTO
    {
        public int idTipoZona { get; set; }
        public string? nombreZona { get; set; }
        public decimal precioAsiento { get; set; }
    }
}
