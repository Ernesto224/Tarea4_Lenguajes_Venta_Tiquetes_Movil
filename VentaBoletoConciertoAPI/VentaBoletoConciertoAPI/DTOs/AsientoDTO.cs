using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venta.BC.Modelos
{
    public class AsientoDTO
    {
        public int idAsiento { get; set; }
        public string? codigoAsiento { get; set; }

    }
}
