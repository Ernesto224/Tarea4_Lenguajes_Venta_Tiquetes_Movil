using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venta.BC.Modelos;
using Ventan.DA.Entidades;

namespace Venta.DA.Entidades
{
    [Table("venta")]
    public class VentaRegistradaDA
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idVenta { get; set; }

        [Required]
        public int idUsuario { get; set; }

        [ForeignKey("idUsuario")]
        public UsuarioDA? usuario { get; set; }

        [Required]
        public DateTime fechaDeCompra { get; set; } = DateTime.Now;

        [Required]
        public decimal pagoTotal { get; set; }

        public ICollection<VentaBoletoDA>? ventaBoletos { get; set; }
    }
}
