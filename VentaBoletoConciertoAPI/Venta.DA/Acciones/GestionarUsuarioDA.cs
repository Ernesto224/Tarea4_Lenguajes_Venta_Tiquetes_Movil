using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venta.BC.Modelos;
using Venta.BW.Interfaces.DA;
using Ventan.DA.Contexto;
using Ventan.DA.Entidades;

namespace Venta.DA.Acciones
{
    public class GestionarUsuarioDA : IGestionarUsuarioDA
    {
        private readonly ContextoData _contextoData;

        public GestionarUsuarioDA(ContextoData contextoData)
        {
            _contextoData = contextoData;
        }

        public async Task<Usuario> InicioDeSesion(Usuario usuario)
        {
       
            //se realiza un busqueda de la tupla de usuario segun el correo y contrasenia proporcionado
            var usuarioDA = await this._contextoData.UsuarioDA.FirstOrDefaultAsync(
                tupla => tupla.correoElectronico == usuario.CorreoElectronico 
                && tupla.contrasenia == usuario.Contrasenia
                );
            
            if (usuarioDA is null) 
            {
                return null;
            }

            //el objeto encontrado es mapedado en un usuario para ser retoenado
            return new Usuario { 
                IdUsuario = usuarioDA.idUsuario, 
                Nombre = usuarioDA.nombre,
                Apellido = usuarioDA.apellido,
                FechaNacimiento = usuarioDA.fechaNacimiento,
                CorreoElectronico = usuarioDA.correoElectronico,
            };
        }

        public async Task<bool> RegistroDeUsuario(Usuario usuario)
        {
            //se valida que el correo ingresado sea unico
            var usuarioDa = await this._contextoData.UsuarioDA.FirstOrDefaultAsync(
                tupla => tupla.correoElectronico == usuario.CorreoElectronico
                );

            if (usuarioDa != null) 
            {
                return false;
            }

            //se mapea el usuario a un DA
            var nuevoUsuario = new UsuarioDA { 
                nombre = usuario.Nombre,
                apellido = usuario.Apellido,
                fechaNacimiento = usuario.FechaNacimiento,
                correoElectronico = usuario.CorreoElectronico,
                contrasenia = usuario.Contrasenia
            };

            //se agrega la tupla nueva
            await this._contextoData.UsuarioDA.AddAsync( nuevoUsuario );

            //se guardan los cambios
            var resultado = await this._contextoData.SaveChangesAsync();

            //se verifica el resultado de la operacion de guardado
            if (resultado <= 0) 
            {
                return false;
            }

            return true;
        }
    }
}
