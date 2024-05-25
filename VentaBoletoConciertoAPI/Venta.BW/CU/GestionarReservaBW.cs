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
    public class GestionarReservaBW : IGestionarReservaBW
    {
        private readonly IGestionarReservaDA gestionarReservaDA;

        public GestionarReservaBW(IGestionarReservaDA gestionarReservaDA)
        {
            this.gestionarReservaDA = gestionarReservaDA;
        }

        public async Task<IEnumerable> GetReservasPorUsuario(int idUsuario)
        {
            return await this.gestionarReservaDA.GetReservasPorUsuario(idUsuario);
        }

        public async Task<bool> RealizarNuevaReserva(int idUsuario, int idAsiento, DateTime fechaCompra)
        {
            return await this.gestionarReservaDA.RealizarNuevaReserva(idUsuario, idAsiento, fechaCompra);
        }
    }
}
