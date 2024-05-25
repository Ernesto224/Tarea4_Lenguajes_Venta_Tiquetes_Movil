using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venta.BC.Modelos;
using Venta.BW.Interfaces.BW;
using Venta.BW.Interfaces.DA;

namespace Venta.BW.CU
{
    public class GestionarTipoZonaBW : IGestionarTipoZonaBW
    {
        private readonly IGestionarTipoZonaDA gestionarTipoZonaDA;

        public GestionarTipoZonaBW(IGestionarTipoZonaDA gestionarTipoZonaDA)
        {
            this.gestionarTipoZonaDA = gestionarTipoZonaDA;
        }

        public async Task<IEnumerable> ListarTiposDeZonas(int idConcierto)
        {
            return await this.gestionarTipoZonaDA.ListarTiposDeZonas(idConcierto); 
        }
    }
}
