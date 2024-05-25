using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venta.BC.Modelos;

namespace Venta.DA.Entidades
{
    public class Boleto
    {
        public int idBoleto { get; set; }
        public Asiento? Asiento { get; set; }
    }
}
