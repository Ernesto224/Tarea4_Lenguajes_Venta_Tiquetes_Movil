using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venta.BW.Interfaces.BW;
using Venta.BW.Interfaces.DA;

namespace Venta.BW.CU
{
    public class GestionarConciertoBW : IGestionarConciertoBW
    {
        private readonly IGestionarConciertoDA gestionarConciertoDA;

        public GestionarConciertoBW(IGestionarConciertoDA gestionarConciertoDA)
        {
            this.gestionarConciertoDA = gestionarConciertoDA;
        }

        public async Task<IEnumerable> ListarConciertos()
        {
           return await this.gestionarConciertoDA.ListarConciertos();
        }
    }
}
