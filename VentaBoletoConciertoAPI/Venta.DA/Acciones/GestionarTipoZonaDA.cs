using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venta.BW.Interfaces.DA;
using Venta.DA.Entidades;
using Ventan.DA.Contexto;

namespace Venta.DA.Acciones
{
    public class GestionarTipoZonaDA : IGestionarTipoZonaDA
    {
        private readonly ContextoData _contextoData;

        public GestionarTipoZonaDA(ContextoData contextoData)
        {
            _contextoData = contextoData;
        }

        public async Task<IEnumerable> ListarTiposDeZonas(int idConcierto)
        {
            var tiposZona = await this._contextoData.AsientoDA
                .Where(tupla => tupla.idConcierto == idConcierto)
                .Select(tupla => tupla.TipoZona).Distinct()
                .Select(tipoZona => new TipoZona() { 
                    idTipoZona = tipoZona.idTipoZona,
                    nombreZona = tipoZona.nombreZona,
                    precioAsiento = tipoZona.precioAsiento,
                }).ToListAsync();

            return tiposZona;
        }
    }
}
