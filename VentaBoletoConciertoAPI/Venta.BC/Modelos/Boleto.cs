using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venta.DA.Entidades
{
    public class Boleto
    {
        public int idBoleto { get; set; }
        public int idAsiento { get; set; }
        public int idConcierto { get; set; }
    }
}
