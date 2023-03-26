using Microsoft.AspNetCore.Mvc;
using Negocio;
using WebApplication1.Modelos;

namespace WebApplication1.Controllers.Logica
{
    [ApiController]
    [Route("usuario")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet]
        [Route("listar")]
        public dynamic listarUsuario()
        {
            List<Usuario> usuarios = new List<Usuario>();
            usuarios = UsuarioNegocio.ListarUsuarios();
            return usuarios;

        }


        [HttpPost]
        [Route("crear")]
        public dynamic crearUsuario(UsuarioCrear user)
        {
            return UsuarioNegocio.crearUsuario(user);
        }


        [HttpDelete]
        [Route("borrar")]
        public dynamic borrarUsuario(int id)
        {
            return UsuarioNegocio.borrarUsuario(id);
        }

        [HttpPut]
        [Route("actualizar")]
        public dynamic actualizarUsuario(UsuarioCrear user)
        {
        return UsuarioNegocio.actualizarUsuario(user);
        }
       
     




    }
}
