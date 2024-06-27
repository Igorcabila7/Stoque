using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;
using Stock.Domain.Entities;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Stock.Infra.loc;
using System.IdentityModel.Tokens.Jwt;


namespace Stock.Infra.loc.Sevices
{
    public class TokenService
    {
        public static object GenerationToken(Usuario usuario)
        {
            var paddedKey = "API_TLP".PadRight(32, '0');
            string kkkk = "hahahaha";
            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(paddedKey));
            var claims = new[] {
                new Claim(JwtRegisteredClaimNames.Sub, usuario.UserNomeCompleto),
                new Claim("id", usuario.Id.ToString()),
                new Claim("nome", usuario.UserNomeCompleto)
            };
            var token = new JwtSecurityToken(
                issuer: "API_TLP",
                audience: "API",
                claims: claims,
                expires: DateTime.UtcNow.AddDays(300),
                signingCredentials: new SigningCredentials(key, SecurityAlgorithms.Aes128CbcHmacSha256)

             );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
