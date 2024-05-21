using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venta.BW.Interfaces.DA;
using Ventan.DA.Contexto;

namespace Ventan.DA.Acciones
{
    public class GestionarVentaDA:IGestionarVentaDA
    {
        private readonly ContextoData contextoData;
        public GestionarVentaDA(ContextoData _contextoData)
        {
            this.contextoData = _contextoData;
        }
    }
}
