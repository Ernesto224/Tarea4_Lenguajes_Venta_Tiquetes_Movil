using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venta.DA.Entidades;

namespace Venta.BC.Modelos
{
    public class Asiento
    {
        public int idAsiento { get; set; }
        public string? codigoAsiento { get; set; }
        public TipoZona? TipoZona { get; set; }
        public Concierto? Concierto { get; set; }
        public bool reservado { get; set; }

    }
}
