﻿using Venta.BC.Modelos;

namespace VentaBoletoConciertoAPI.Utilitarios
{
    public static class ConciertoMapper
    {
        public static ConciertoDTO ConciertoToDTO(Concierto concierto)
        {

            return new ConciertoDTO
            {
                IdConcierto = concierto.idConcierto,
                ImagenArtista = concierto.imagenArtista,
                NombreArtista = concierto.nombreArtista,
                FechaEvento = concierto.fechaEvento,
                UbicacionConcierto = concierto.ubicacionConcierto
            };
        }

        public static IEnumerable<ConciertoDTO> ConciertosToDTOs(IEnumerable<Concierto> conciertos)
        {

            return conciertos.Select(concierto => ConciertoToDTO(concierto)).ToList();
        }
    }
}
