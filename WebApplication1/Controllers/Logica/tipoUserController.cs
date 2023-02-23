using Microsoft.AspNetCore.Mvc;
using Negocio;
using WebApplication1.Modelos;

namespace WebApiEma.Controllers.Logica
{
    [ApiController]
    [Route("roles")]
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

        [HttpGet]
        [Route("listartipoID")]
        public dynamic listarTipoUserid(int id)
        {
            Tipouser usuarioTipo = new Tipouser();
            usuarioTipo = TipoUserNegocio.ListarUsuarios(id);
            return usuarioTipo;
        }

        [HttpPut]
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
        
        [HttpDelete]
        [Route("eliminartipo")]
        public dynamic eliminarTipo(Tipouser tipoRol)
        {
            return TipoUserNegocio.eliminarTipo(tipoRol);
        }
    }
}
