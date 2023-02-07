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
            return usuarios.Select(us => new {us.Idusuario, us.Usuario1, us.Password, us.IdtipoNavigation.Idtipo, us.IdtipoNavigation.Tipo});

        }
    }
}
