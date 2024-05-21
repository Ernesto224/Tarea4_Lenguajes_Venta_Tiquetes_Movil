using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venta.BC.Modelos
{
    public class Concierto
    {
        public int IdConcierto { get; set; }
        public string ImagenArtista { get; set; }
        public string NombreArtista { get; set; }
        public DateTime FechaEvento { get; set; }
        public string UbicacionConcierto { get; set; }
    }
}
