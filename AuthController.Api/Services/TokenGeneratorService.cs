using AuthController.Api.Constants;
using AuthController.Api.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AuthController.Api.Services
{
    public class TokenGeneratorService
    {
        public string SecretKey = "{CD79CFDA-0993-45C1-BB9D-4096C0316B09}";

        public string GetToken(User user)
        {
            var jwtToken = GetJwtToken(user);
            var token = new JwtSecurityTokenHandler().WriteToken(jwtToken);
            return token;
        }

        public JwtSecurityToken GetJwtToken(User user)
        {
            var claims = GetClaims(user);

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SecretKey));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            return new JwtSecurityToken(issuer: "Todo.ServerApp", 
                audience: "Todo.ClientApp",
                claims :  claims,
                notBefore : DateTime.UtcNow,
                expires : DateTime.Now.AddDays(1),
                signingCredentials : credentials);
        }

        public List<Claim> GetClaims(User user)
        {
            return new List<Claim>()
            {
                new Claim(ClaimTypes.Email, user.EmailAddress),
                new Claim(ClaimConstants.UserId, user.Id.ToString())
            };
        }
    }
}
