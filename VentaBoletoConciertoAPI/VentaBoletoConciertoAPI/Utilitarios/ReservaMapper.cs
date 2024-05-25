using Venta.BC.Modelos;
using Venta.DA.Entidades;

namespace VentaBoletoConciertoAPI.Utilitarios
{
    public static class ReservaMapper
    {

        public static IEnumerable<ReservaDTO> MapToReservaDTO(IEnumerable<Reserva> reservas)
        {
            return reservas.Select(r => new ReservaDTO
            {
                idUsuario = r.idUsuario,
                fechaDeCompra = r.fechaDeCompra,
                Asiento = r.Asiento != null ? new Asiento
                {
                    idAsiento = r.Asiento.idAsiento,
                    codigoAsiento = r.Asiento.codigoAsiento,
                    TipoZona = r.Asiento.TipoZona != null ? new TipoZona
                    {
                        idTipoZona = r.Asiento.TipoZona.idTipoZona,
                        nombreZona = r.Asiento.TipoZona.nombreZona,
                        precioAsiento = r.Asiento.TipoZona.precioAsiento
                    } : null,
                    Concierto = r.Asiento.Concierto != null ? new Concierto
                    {
                        idConcierto = r.Asiento.Concierto.idConcierto,
                        imagenArtista = r.Asiento.Concierto.imagenArtista,
                        nombreArtista = r.Asiento.Concierto.nombreArtista,
                        fechaEvento = r.Asiento.Concierto.fechaEvento,
                        ubicacionConcierto = r.Asiento.Concierto.ubicacionConcierto
                    } : null
                } : null
            }).ToList();
        }

    }
}
