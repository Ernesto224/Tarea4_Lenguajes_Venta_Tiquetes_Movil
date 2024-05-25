using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venta.BC.Modelos
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public string? nombre { get; set; }
        public string? apellido { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string? correoElectronico { get; set; }
        public string? contrasenia { get; set; }
    }
}
