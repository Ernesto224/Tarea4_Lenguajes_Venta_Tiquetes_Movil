using Venta.BC.Modelos;

namespace VentaBoletoConciertoAPI.Utilitarios
{
    public static class UsuarioMapper
    {

        public static UsuarioDTO UserToDTO(Usuario usuario)
        {
            return new UsuarioDTO
            {
                IdUsuario = usuario.idUsuario,
                Nombre = usuario.nombre,
                Apellido = usuario.apellido,
                CorreoElectronico = usuario.correoElectronico
            };
        }

    }
}
