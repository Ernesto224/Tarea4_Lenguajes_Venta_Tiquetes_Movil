using Venta.BC.Modelos;
using Venta.DA.Entidades;

namespace VentaBoletoConciertoAPI.Utilitarios
{
    public static class TipoZonaMapper
    {
        public static TipoZonaDTO TipoZonaToDTO(TipoZona tipoZona)
        {

            return new TipoZonaDTO()
            {
                idTipoZona = tipoZona.idTipoZona,
                nombreZona = tipoZona.nombreZona,
                precioAsiento = tipoZona.precioAsiento,
            };
        }

        public static IEnumerable<TipoZonaDTO> TiposZonaToDTOs(IEnumerable<TipoZona> zonas)
        {

            return zonas.Select(zona => TipoZonaToDTO(zona)).ToList();
        }
    }
}
