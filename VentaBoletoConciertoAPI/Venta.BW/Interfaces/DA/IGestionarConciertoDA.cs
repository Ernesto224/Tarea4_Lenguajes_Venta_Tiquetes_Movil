﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venta.BC.Modelos;

namespace Venta.BW.Interfaces.DA
{
    public interface IGestionarConciertoDA
    {
        public Task<IEnumerable> ListarConciertos();
        public Task<Concierto> GetConcierto(int idConcierto);
    }
}
