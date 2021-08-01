using LojaVirtual.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtual.Classes
{
    public static class TokenService
    {
        private static byte[] Key;
        public static byte[] getKey()
        {
            if (Key == null)
            {
                var key = Aes.Create();
                Key = key.Key;
            }
            var secret = Key;
            return secret;
        }

        public static string GenerateToken(Users user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = getKey();
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.UserName.ToString()),
                    new Claim(ClaimTypes.Role, user.Role),
                    new Claim(ClaimTypes.Email, user.Email),
                }),
                Expires = DateTime.UtcNow.AddMinutes(30), //alterar para segundos
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
        public static string HASHCalculate(string Password)
        {
            return Convert.ToBase64String(SHA512.HashData(Encoding.UTF8.GetBytes(Password)));
        }
        public static bool CompareHASH(string Password, string HASH)
        {
            var hashcalc = HASHCalculate(Password);
            return hashcalc == HASH;
        }
    }
}
