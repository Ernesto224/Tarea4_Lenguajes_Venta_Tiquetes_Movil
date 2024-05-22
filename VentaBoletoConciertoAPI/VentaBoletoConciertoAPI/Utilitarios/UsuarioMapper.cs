using Venta.BC.Modelos;

namespace VentaBoletoConciertoAPI.Utilitarios
{
    public static class UsuarioMapper
    {

        public static UsuarioDTO UserToDTO(Usuario usuario)
        {
            return new UsuarioDTO
            {
                IdUsuario = usuario.IdUsuario,
                Nombre = usuario.Nombre,
                Apellido = usuario.Apellido,
                CorreoElectronico = usuario.CorreoElectronico
            };
        }

    }
}
