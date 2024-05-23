using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venta.BW.Interfaces.BW;
using Venta.BW.Interfaces.DA;

namespace Venta.BW.CU
{
    public class GestionarAsientoBW : IGestionarAsientosBW
    {
        private readonly IGestionarAsientosDA gestionarAsientosDA;

        public GestionarAsientoBW(IGestionarAsientosDA gestionarAsientosDA)
        {
            this.gestionarAsientosDA = gestionarAsientosDA;
        }

        public async Task<IEnumerable> AsientosDisponiblesPorConciertoYZona(int idConcierto, int idTipoZona)
        {
            return await this.gestionarAsientosDA.AsientosDisponiblesPorConciertoYZona(idConcierto, idTipoZona);
        }
    }
}
