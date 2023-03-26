using Microsoft.AspNetCore.Mvc;
using Modelos.Modelos;
using Negocio;
using WebApplication1.Modelos;

namespace WebApiEma.Controllers.Logica
{
    [ApiController]
    [Route("Login")]
    public class LoginController : Controller
    {
        private IConfiguration _configuration;
 
        public LoginController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost]
        [Route("login")]
        public dynamic Login(LoginDTO login)
        {
            LoginNegocio loginNegocio = new LoginNegocio(_configuration);
            return loginNegocio;
        }
    }

}
