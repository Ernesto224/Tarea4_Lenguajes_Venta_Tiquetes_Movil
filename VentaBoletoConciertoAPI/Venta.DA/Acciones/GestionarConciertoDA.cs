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
    public class GestionarConciertoDA : IGestionarConciertoDA
    {
        private readonly ContextoData _contextoData;

        public GestionarConciertoDA(ContextoData contextoData)
        {
            this._contextoData = contextoData;
        }

        public async Task<IEnumerable> ListarConciertos()
        {
            //se recuperan todos los conciertos y se mapean a un usuario valido
            var lista = await this._contextoData.ConciertoDA.Select(concietoDA => new Concierto() 
                { 
                    IdConcierto = concietoDA.idConcierto,
                    ImagenArtista = concietoDA.imagenArtista,
                    NombreArtista = concietoDA.nombreArtista,
                    FechaEvento = concietoDA.fechaEvento,
                    UbicacionConcierto = concietoDA.ubicacionConcierto
                }
            ).ToListAsync();

            return lista;
        }
    }
}
