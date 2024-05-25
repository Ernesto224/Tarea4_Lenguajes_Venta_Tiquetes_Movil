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
            //se localizan los hacientos disponibles para ese concierto y que coicidan con el id de zona
            //y se mapean solo las caracteristicas necesarias para el envio de datos
            var asientos = await this._contextoData.AsientoDA
                .Where(tupla => tupla.idConcierto == idConcierto 
                && tupla.idTipoZona == idTipoZona
                && !tupla.reservado) 
                .Select(tupla => new Asiento()
                {
                    idAsiento =  tupla.idAsiento,
                    numeroAsiento = tupla.numeroAsiento,
                    reservado = tupla.reservado,
                }).ToListAsync();

            return asientos;

        }
    }
}
