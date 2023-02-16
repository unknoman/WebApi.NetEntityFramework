using Datos;
using Microsoft.IdentityModel.Tokens;
using WebApplication1.Modelos;

namespace Negocio
{

    // Estos son los metodos de los roles de los usuarios
    public static class TipoUserNegocio
    {
        public static List<Tipouser> ListarTipoUsuarios()
        {
            List<Tipouser> tipoUsuarios = new List<Tipouser>();
            tipoUsuarios = tiposUserMetodos.listarTipo();
            return tipoUsuarios;
        }

        public static Tipouser ListarUsuarios(int id)
        {
            Tipouser tipoUsuariosId = new Tipouser();
            tipoUsuariosId = tiposUserMetodos.listarTipo(id);
            return tipoUsuariosId;
        }

        // agregar en main 
        public static bool eliminarTipo(Tipouser tipo)
        {
            if(tipo != null)
            {
               return tiposUserMetodos.eliminarTipo(tipo);
            }
            else
            {
                return false;
            }
            
        }

        public static bool actualizarTipo(Tipouser tipoActualizado)
        {
            if(!String.IsNullOrEmpty(tipoActualizado.Tipo))
            {
                tiposUserMetodos.actualizarTipo(tipoActualizado);
                return true;
            } else
            {
                return false; 
            }    
        }


        public static bool crearTipo(Tipouser tipo)
        {
            if (!String.IsNullOrEmpty(tipo.Tipo))
            {
                tiposUserMetodos.crearTipo(tipo);
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
