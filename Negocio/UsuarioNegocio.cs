using Datos;
using Microsoft.IdentityModel.Tokens;
using WebApplication1.Modelos;

namespace Negocio
{
    public static class UsuarioNegocio
    {
        public static List<Usuario> ListarUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            usuarios = UsuarioMetodos.listarUsuarios();
            return usuarios;
        }

        public static bool borrarUsuario(Usuario user)
        {
            UsuarioMetodos.borrarUsuario(user);
            return true;
        }


        public static bool crearUsuario(UsuarioCrear user)
        {
           if(String.IsNullOrEmpty(user.Usuario1))
            {
                return false;
            }
            if (String.IsNullOrEmpty(user.Password))
            {
                return false;
            }
            UsuarioMetodos.crearUsuario(user);
            return true;
        }


        public static bool actualizarUsuario(Usuario user)
        {
            if (String.IsNullOrEmpty(user.Usuario1))
            {
                return false;
            }
            if (String.IsNullOrEmpty(user.Password))
            {
                return false;
            }
            UsuarioMetodos.actualizarUsuario(user);
            return true;
        }
    }
}