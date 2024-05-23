using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venta.BW.Interfaces.DA
{
    public interface IGestionarTipoZonaDA
    {
        public Task<IEnumerable> ListarTiposDeZonas();
    }
}
