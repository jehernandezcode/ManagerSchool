using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using SchoolManagement.Domain.Common;

namespace SchoolManagement.Infrastructure.Authentication
{
    public class AuthentificationServiceInfra : IAuthenticationServiceInfra
    {
        private readonly string _secretKey;
        private readonly string _issuer;
        private readonly string _audience;
        private readonly decimal _expireAt;

        public AuthentificationServiceInfra(string audience, string issuer, string secretKey, decimal expireAt)
        {
            _audience = audience;
            _issuer = issuer;
            _secretKey = secretKey;
            _expireAt = expireAt;
        }

        public async Task<string> GenerateToken(string username, string role)
        {
            var claims = new[]
        {
            new Claim(ClaimTypes.Name, username),
            new Claim(ClaimTypes.Role, role)
        };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_secretKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _issuer,
                audience: _audience,
                claims: claims,
                expires: DateTime.Now.AddMinutes((double)_expireAt),
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public ClaimsPrincipal? ValidateToken(string token)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            try
            {
                var principal = tokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = _issuer,
                    ValidAudience = _audience,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_secretKey))
                }, out var validatedToken);
                return principal;
            }
            catch
            {
                return null;
            }
        }
    }
}
