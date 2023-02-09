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
            List<Usuario> usuarios= new List<Usuario>();
            usuarios = UsuarioNegocio.ListarUsuarios();
            return usuarios;
          //  return usuarios.Select(us => new {us.Idusuario, us.Usuario1, us.Password, us.IdtipoNavigation.Idtipo, us.IdtipoNavigation.Tipo});

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







    }
}
