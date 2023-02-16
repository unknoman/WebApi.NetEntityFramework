using Microsoft.AspNetCore.Mvc;
using Negocio;
using WebApplication1.Modelos;

namespace WebApiEma.Controllers.Logica
{
    public class tipoUserController : Controller
    {
        [HttpGet]
        [Route("listartipo")]
        public dynamic listarTipoUser()
        {
            List<Tipouser> lista = new List<Tipouser>();
           lista = TipoUserNegocio.ListarTipoUsuarios();
            return lista;
        }

        [HttpPost]
        [Route("listartipo")]
        public dynamic listarTipoUserid(int id)
        {
            Tipouser usuarioTipo = new Tipouser();
            usuarioTipo = TipoUserNegocio.ListarUsuarios(id);
            return usuarioTipo;
        }

        [HttpPost]
        [Route("actualizartipo")]
        public dynamic actualizarTipo(Tipouser tipoActualizado)
        {
                return TipoUserNegocio.actualizarTipo(tipoActualizado);

        }

        [HttpPost]
        [Route("creartipo")]
        public dynamic crearTipo(Tipouser tipoRol)
        {
            return TipoUserNegocio.crearTipo(tipoRol);
        }

        [HttpPost]
        [Route("eliminartipo")]
        public dynamic eliminarTipo(Tipouser tipoRol)
        {
            return TipoUserNegocio.eliminarTipo(tipoRol);
        }
    }
}
