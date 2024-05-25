using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venta.BC.Modelos;
using Venta.BW.Interfaces.DA;
using Venta.DA.Entidades;
using Ventan.DA.Contexto;

namespace Venta.DA.Acciones
{
    public class GestionarReservaDA : IGestionarReservaDA
    {
        private readonly ContextoData _contextoData;

        public GestionarReservaDA(ContextoData contextoData)
        {
            this._contextoData = contextoData;
        }

        public async Task<IEnumerable> GetReservasPorUsuario(int idUsuario)
        {
            var reservas = await _contextoData.ReservaDA
                .Include(r => r.Asiento)
                    .ThenInclude(a => a.Concierto)
                .Include(r => r.Asiento)
                    .ThenInclude(a => a.TipoZona)
                .Where(r => r.idUsuario == idUsuario)
                .Select(r => new Reserva
                {
                    idUsuario = r.idUsuario,
                    fechaDeCompra = r.fechaDeCompra,
                    Asiento = new Asiento
                    {
                        idAsiento = r.Asiento.idAsiento,
                        codigoAsiento = r.Asiento.codigoAsiento,
                        TipoZona = new TipoZona
                        {
                            idTipoZona = r.Asiento.TipoZona.idTipoZona,
                            nombreZona = r.Asiento.TipoZona.nombreZona,
                            precioAsiento = r.Asiento.TipoZona.precioAsiento
                        },
                        Concierto = new Concierto
                        {
                            idConcierto = r.Asiento.Concierto.idConcierto,
                            imagenArtista = r.Asiento.Concierto.imagenArtista,
                            nombreArtista = r.Asiento.Concierto.nombreArtista,
                            fechaEvento = r.Asiento.Concierto.fechaEvento,
                            ubicacionConcierto = r.Asiento.Concierto.ubicacionConcierto
                        }
                    }
                })
                .ToListAsync();

            if(reservas == null)
            {
                return null;
            }

            return reservas;
        }


        public async Task<bool> RealizarNuevaReserva(int idUsuario, int idAsiento, DateTime fechaCompra)
        {
            var nuevaReserva = new ReservaDA()
            {
                idUsuario = idUsuario,
                idAsiento = idAsiento,
                fechaDeCompra = fechaCompra
            };

            await this._contextoData.ReservaDA.AddAsync(nuevaReserva);

            var resultado = await _contextoData.SaveChangesAsync();

            if (resultado > 0)
            {
                return true;
            }

            return false;

        }

    }
}
