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

        public dynamic crearUsuario(Usuario user)
        {
            bool resultado = UsuarioNegocio.crearUsuario(user);
            return resultado;
        }



        [HttpPost]
        [Route("borrar")]
        public dynamic borrarUsuario(Usuario user)
        {
            bool resultado = UsuarioNegocio.borrarUsuario(user);
            return resultado;
        }

        [HttpPost]
        [Route("actualizar")]
        public dynamic actualizarUsuario(Usuario user)
        {
            bool resultado = UsuarioNegocio.actualizarUsuario(user);
            return resultado;
        }
       
        // test comit 




    }
}
