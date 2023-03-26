using Castle.Core.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Modelos.Modelos;
using System.Diagnostics.CodeAnalysis;
using System.Security.Claims;
using System.Xml.Linq;
using WebApplication1.Modelos;
using IConfiguration = Microsoft.Extensions.Configuration.IConfiguration;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.Identity.Client.Platforms.Features.DesktopOs.Kerberos;

namespace Datos
{
    public class LoginMetodos
    {

        public static dynamic login(LoginDTO login)
        {
            using (ApiEmaContext db = new ApiEmaContext())
            {
                var usuario = db.Usuarios.Where(usuario => usuario.Usuario1 == login.Usuario1 && usuario.Password == login.Password).FirstOrDefault();
                return usuario;
            }
        }


    }

}
