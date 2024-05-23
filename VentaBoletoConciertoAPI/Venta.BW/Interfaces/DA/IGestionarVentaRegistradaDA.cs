using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venta.DA.Entidades;

namespace Venta.BW.Interfaces.DA
{
    public interface IGestionarVentaRegistradaDA
    {
        public Task<VentaRegistrada> RealizarNuevaVenta(int idUsuario, IEnumerable<int> idsAsientos, decimal pagoTotal);
    }
}
