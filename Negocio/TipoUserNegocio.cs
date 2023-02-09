using Datos;
using Microsoft.IdentityModel.Tokens;
using WebApplication1.Modelos;

namespace Negocio
{
    public static class TipoUserNegocio
    {
        public static List<Tipouser> ListarTipoUsuarios()
        {
            List<Tipouser> tipoUsuarios = new List<Tipouser>();
            tipoUsuarios = tiposUserMetodos.listarTipo();
            return tipoUsuarios;
        }

        public static Tipouser ListarUsuariosId(int id)
        {
            Tipouser tipoUsuariosId = new Tipouser();
            tipoUsuariosId = tiposUserMetodos.listarTipoId(id);
            return tipoUsuariosId;
        }


    }
}
