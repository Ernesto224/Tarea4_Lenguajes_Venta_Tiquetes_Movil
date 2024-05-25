﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venta.DA.Entidades;

namespace Venta.BW.Interfaces.DA
{
    public interface IGestionarReservaDA
    {
        public Task<bool> RealizarNuevaReserva(int idUsuario, int idAsiento, DateTime fechaCompra);
        public Task<IEnumerable> GetReservasPorUsuario(int idUsuario);
    }
}
