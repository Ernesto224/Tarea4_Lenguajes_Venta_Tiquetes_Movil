using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venta.BC.Modelos;
using Venta.BW.Interfaces.BW;
using Venta.BW.Interfaces.DA;

namespace Venta.BW.CU
{
    public class GestionarUsuarioBW : IGestionarUsuarioBW
    {
        private readonly IGestionarUsuarioDA gestionarUsuarioDA;

        public GestionarUsuarioBW(IGestionarUsuarioDA gestionarUsuarioDA)
        {
            this.gestionarUsuarioDA = gestionarUsuarioDA;
        }

        public async Task<Usuario> InicioDeSesion(string correoElectronico, string contrasenia)
        {
           return await this.gestionarUsuarioDA.InicioDeSesion(correoElectronico, contrasenia);
        }

        public async Task<bool> RegistroDeUsuario(Usuario usuario)
        {
            return await this.gestionarUsuarioDA.RegistroDeUsuario(usuario);
        }
    }
}
