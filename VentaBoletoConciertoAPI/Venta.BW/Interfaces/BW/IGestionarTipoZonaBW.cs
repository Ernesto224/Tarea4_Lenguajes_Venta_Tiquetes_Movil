using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venta.BW.Interfaces.BW
{
    public interface IGestionarTipoZonaBW
    {
        public Task<IEnumerable> ListarTiposDeZonas(int idConcierto);
    }
}
