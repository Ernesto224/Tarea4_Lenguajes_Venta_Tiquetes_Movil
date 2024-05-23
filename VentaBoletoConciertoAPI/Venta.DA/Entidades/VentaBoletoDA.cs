using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventan.DA.Entidades;

namespace Venta.DA.Entidades
{
    [Table("ventaBoleto")]
    public class VentaBoletoDA
    {
        [Required]
        public int idVenta { get; set; }

        [ForeignKey("idVenta")]
        public VentaRegistradaDA? venta { get; set; }

        [Required]
        public int idBoleto { get; set; }

        [ForeignKey("idBoleto")]
        public BoletoDA? boletoDA { get; set; }
    }
}
