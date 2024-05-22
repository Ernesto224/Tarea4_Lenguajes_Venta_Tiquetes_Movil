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
    [Table("reserva")]
    public class ReservaDA
    {
        [Required]
        public int idUsuario { get; set; }

        [ForeignKey("idUsuario")]
        public UsuarioDA? UsuarioDA { get; set; }

        [Required]
        public int idBoleto { get; set; }

        [ForeignKey("idBoleto")]
        public BoletoDA? BoletoDA { get; set; }
    }
}
