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
    [Table("reserva")]
    public class ReservaDA
    {
        [Required]
        public int idUsuario { get; set; }

        [Required]
        public int idAsiento { get; set; }

        [ForeignKey("idAsiento")]
        public AsientoDA? Asiento { get; set; }

        public DateTime fechaDeCompra { get; set; }
    }
}
