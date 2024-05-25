using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venta.DA.Entidades;

namespace Venta.BW.Interfaces.BW
{
    public interface IGestionarVentaRegistradaBW
    {
        public Task<VentaRegistrada> RealizarNuevaVenta(object informacionDeVenta);
    }
}
