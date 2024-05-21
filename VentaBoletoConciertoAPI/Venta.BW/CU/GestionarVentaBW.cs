using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venta.BW.Interfaces.BW;
using Venta.BW.Interfaces.DA;

namespace Venta.BW.CU
{
    public class GestionarVentaBW: IGestionarVentaBW
    {
        private readonly IGestionarVentaDA gestionarVentaDA;
        public GestionarVentaBW(IGestionarVentaDA _gestionarVentaDA)
        {
            this.gestionarVentaDA = _gestionarVentaDA;
        }
    }
}
