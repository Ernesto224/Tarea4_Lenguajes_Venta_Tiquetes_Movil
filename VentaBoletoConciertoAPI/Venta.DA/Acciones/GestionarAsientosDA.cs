using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venta.BC.Modelos;
using Venta.BW.Interfaces.DA;
using Ventan.DA.Contexto;

namespace Venta.DA.Acciones
{
    public class GestionarAsientosDA : IGestionarAsientosDA
    {
        private readonly ContextoData _contextoData;

        public GestionarAsientosDA(ContextoData contextoData) 
        {
            this._contextoData = contextoData;
        }

        public async Task<IEnumerable> AsientosDisponiblesPorConciertoYZona(int idConcierto, int idTipoZona)
        {
            ////se localizan los hacientos disponibles para ese concierto y que coicidan con el id de zona
            //var asientos = await this._contextoData.AsientoDA
            //    .Where(asientoDA => asientoDA.idConcieto == idConcierto && asientoDA.idTipoZona == idTipoZona)
            //    .Select(asientoDA => new Asiento(){
                    
            //    }).ToListAsync();

            return null;

        }
    }
}
