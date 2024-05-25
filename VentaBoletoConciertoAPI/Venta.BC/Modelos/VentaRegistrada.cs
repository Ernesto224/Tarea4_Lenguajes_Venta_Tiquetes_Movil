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
    public class VentaRegistrada
    {
        public int idVenta { get; set; }
        public Usuario? usuario { get; set; }
        public DateTime fechaDeCompra { get; set; }
        public decimal pagoTotal { get; set; }
        public ICollection<Boleto>? boletos { get; set; }
    }
}
