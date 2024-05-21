using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venta.BW.Interfaces.BW;

namespace Venta.BW.CU
{
    public class GestionarVentaBW: IGestionarVentaBW
    {
        private readonly IGestionarVentaBW gestionarVentaBW;
        private readonly int cat = 2;
        public GestionarVentaBW(IGestionarVentaBW _gestionarVentaBW)
        {
            this.gestionarVentaBW = _gestionarVentaBW;
        }
    }
}
