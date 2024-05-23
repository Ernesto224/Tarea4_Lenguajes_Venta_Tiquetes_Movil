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
    [Table("boleto")]
    public class BoletoDA
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idBoleto { get; set; }

        [Required]
        public int idAsiento { get; set; }

        [ForeignKey("idAsiento")]
        public AsientoDA? asiento { get; set; }

        [Required]
        public int idConcierto { get; set; }

        [ForeignKey("idConcierto")]
        public ConciertoDA? concierto { get; set;}

    }
}
