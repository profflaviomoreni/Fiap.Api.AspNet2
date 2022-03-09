using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Fiap.Api.AspNet2.Models;
using Microsoft.IdentityModel.Tokens;

namespace Fiap.Api.AspNet2.Service
{
    public class AuthenticationService
    {

        public static string GetToken(UsuarioModel usuario)
        {
            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            byte[] segredo = Encoding.ASCII.GetBytes(Settings.Secret);
            SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, usuario.NomeUsuario.ToString()),
                    new Claim(ClaimTypes.Role, usuario.Regra.ToString()), // Perfil
                }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(segredo),
                    SecurityAlgorithms.HmacSha256Signature)
            };
            SecurityToken token = handler.CreateToken(tokenDescriptor);
            return handler.WriteToken(token);
        }



    }
}
