using Venta.BC.Modelos;

namespace VentaBoletoConciertoAPI.Utilitarios
{
    public static class ConciertoMapper
    {
        public static ConciertoDTO ConciertoToDTO(Concierto concierto)
        {

            return new ConciertoDTO
            {
                IdConcierto = concierto.IdConcierto,
                ImagenArtista = concierto.ImagenArtista,
                NombreArtista = concierto.NombreArtista,
                FechaEvento = concierto.FechaEvento,
                UbicacionConcierto = concierto.UbicacionConcierto
            };
        }

        public static IEnumerable<ConciertoDTO> ConciertosToDTOs(IEnumerable<Concierto> conciertos)
        {

            return conciertos.Select(concierto => ConciertoToDTO(concierto)).ToList();
        }
    }
}
