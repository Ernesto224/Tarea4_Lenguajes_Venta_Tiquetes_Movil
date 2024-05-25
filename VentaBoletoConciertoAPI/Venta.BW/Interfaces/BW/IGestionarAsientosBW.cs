using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venta.BW.Interfaces.BW
{
    public interface IGestionarAsientosBW
    {
        public Task<IEnumerable> AsientosDisponiblesPorConciertoYZona(int idConcierto, int idTipoZona);
        public Task<bool> CambiarEstadoAsiento(int idAsiento);
    }
}
