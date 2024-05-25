using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventan.DA.Entidades
{
    [Table("usuario")]
    public class UsuarioDA
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idUsuario { get; set; }

        [Required]
        public string? nombre { get; set; }

        [Required]
        public string? apellido { get; set; }

        [Required]
        public DateTime fechaNacimiento { get; set; }

        [Required]
        public string? correoElectronico { get; set; }

        [Required]
        public string? contrasenia { get; set; }
    }
}
