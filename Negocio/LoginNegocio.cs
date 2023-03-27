using Datos;
using Microsoft.IdentityModel.Tokens;
using Modelos.Modelos;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebApplication1.Modelos;
using IConfiguration = Microsoft.Extensions.Configuration.IConfiguration;
using Microsoft.Extensions.Configuration;

namespace Negocio
{
    public class LoginNegocio
    {

    private IConfiguration _configuration;
    public LoginNegocio(IConfiguration configuration)
    {
        _configuration = configuration;
    }
       
    

    public static dynamic login(LoginDTO login)
    {
        var usuario = LoginMetodos.login(login);
        if (usuario == null)
        {
            return new
            {
                sucess = false,
                message = "Usuario o contraseñas incorrectas"
            };
        }


            var jwt = _configuration.GetSection("JwtSettings").Get<JwtModel>();

            var claims = new[]
            {

                    new Claim(JwtRegisteredClaimNames.Sub, jwt.Subject),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                    new Claim(JwtRegisteredClaimNames.Sub, jwt.Subject),
                    new Claim("id", usuario.Idusuario.ToString()),
                    new Claim("usuario", usuario.Usuario1),
                    new Claim("idTipo", usuario.Idtipo.ToString()),
                };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwt.SecretKey));
            var SigIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                jwt.Issuer,
                jwt.Audience,
                claims,
                expires: DateTime.Now.AddDays(5),
                signingCredentials: SigIn);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }


    }




}