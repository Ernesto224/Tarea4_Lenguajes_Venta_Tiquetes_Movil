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
        public int numeroAsiento { get; set; }
        public TipoZona? TipoZona { get; set; }
        public Concierto? concierto { get; set; }
        public bool reservado { get; set; }

    }
}
