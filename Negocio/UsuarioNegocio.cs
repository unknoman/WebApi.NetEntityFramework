using Datos;
using WebApplication1.Modelos;

namespace Negocio
{
    public static class UsuarioNegocio
    {
        public static List<Usuario> ListarUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            usuarios = UsuarioMetodos.ListarUsuarios();
            return usuarios;
        }


    }
}