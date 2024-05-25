﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venta.BC.Modelos;

namespace Venta.BW.Interfaces.BW
{
    public interface IGestionarUsuarioBW
    {
        public Task<Usuario> InicioDeSesion(string correoElectronico, string contrasenia);

        public Task<bool> RegistroDeUsuario(Usuario usuario);
    }
}
