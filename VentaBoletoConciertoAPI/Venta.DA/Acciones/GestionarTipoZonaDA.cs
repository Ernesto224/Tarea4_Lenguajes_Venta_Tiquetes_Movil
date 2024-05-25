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

        public async Task<IEnumerable> ListarTiposDeZonas()
        {
            var tiposZona = await this._contextoData.TipoZonaDA.Select(tupla => new TipoZona() 
            { 
                idTipoZona = tupla.idTipoZona,
                nombreZona = tupla.nombreZona,
                precioAsiento = tupla.precioAsiento,
            }).ToListAsync();

            return tiposZona;

        }
    }
}
