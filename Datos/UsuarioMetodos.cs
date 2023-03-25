using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;
using WebApplication1.Modelos;

namespace Datos
{
    public static class UsuarioMetodos
    {

        public static List<Usuario> listarUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            using (ApiEmaContext db = new ApiEmaContext())
            {
                var list1 = db.Usuarios.Include(t => t.IdtipoNavigation);

                foreach (var usuario1 in list1)
                {
                    usuarios.Add(usuario1);
                }
            }
            return usuarios;

        }




        public static bool borrarUsuario(int id)
        {
            using (ApiEmaContext db = new ApiEmaContext())
            {
                Usuario user = new Usuario();
                user.Idusuario = id;
                db.Remove(user);
                db.SaveChanges();
                return true;
            }
        }


        public static bool crearUsuario(UsuarioCrear user)
        {
            using (ApiEmaContext db = new ApiEmaContext())
            {
                try
                {
                    Usuario usuario = new Usuario();
                    usuario.Usuario1 = user.Usuario1;
                    usuario.Password = user.Password;
                    usuario.Idtipo = user.Idtipo;
                    db.Add(usuario);
                   int verificacion = db.SaveChanges();
                    return false;
                } catch (Exception)
                {
                        return false;
                }

            }
        }


        public static bool actualizarUsuario(UsuarioCrear user)
        {
            using (ApiEmaContext db = new ApiEmaContext())
            {
                Usuario usuario = new Usuario();
                usuario.Idusuario = user.Idusuario;
                usuario.Usuario1 = user.Usuario1;
                usuario.Password = user.Password;
                usuario.Idtipo=user.Idtipo;
                db.Update(usuario);
                db.SaveChanges();
                return true;
            }
        }

    }
}