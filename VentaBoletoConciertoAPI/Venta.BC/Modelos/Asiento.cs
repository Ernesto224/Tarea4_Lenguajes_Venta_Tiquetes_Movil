using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venta.BC.Modelos
{
    public class Asiento
    {
        public int idAsiento { get; set; }
        public int numeroAsiento { get; set; }
        public int idTipoZona { get; set; }
        public int idConcierto { get; set; }
        public bool reservado { get; set; }

    }
}
