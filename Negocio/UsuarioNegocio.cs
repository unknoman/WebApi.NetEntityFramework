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

        public static bool borrarUsuario(int id)
        {
            UsuarioMetodos.borrarUsuario(id);
            return true;
        }


        public static bool crearUsuario(UsuarioCrear user)
        {

           if(String.IsNullOrEmpty(user.Usuario1) && String.IsNullOrEmpty(user.Password))
            {
                return false;
            } else
            {
                return UsuarioMetodos.crearUsuario(user);
            }
           
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