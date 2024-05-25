using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venta.BC.Modelos
{
    public class Concierto
    {
        public int idConcierto { get; set; }
        public string? imagenArtista { get; set; }
        public string? nombreArtista { get; set; }
        public DateTime fechaEvento { get; set; }
        public string? ubicacionConcierto { get; set; }
    }
}
