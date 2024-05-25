using Venta.BC.Modelos;
using Venta.DA.Entidades;

namespace VentaBoletoConciertoAPI.Utilitarios
{
    public static class AsientoMapper
    {
        public static AsientoDTO AsientoToDTO(Asiento asiento)
        {

            return new AsientoDTO()
            {
                idAsiento = asiento.idAsiento,
                codigoAsiento = asiento.codigoAsiento,
            };
        }

        public static IEnumerable<AsientoDTO> AsientosToDTOs(IEnumerable<Asiento> asientos)
        {

            return asientos.Select(asiento => AsientoToDTO(asiento)).ToList();
        }
    }
}
