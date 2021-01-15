using Auth_API.Models;
using Auth_API.Services.Contract;
using Auth_API.Setting;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Auth_API.Services
{
    public class TokenService : ITokenService
    {
        private readonly JwtSettings _jwtSettings;

        public TokenService(JwtSettings jwtSettings)
        {
            _jwtSettings = jwtSettings;
        }

        public string GenerateUserToken(User user)
        {
            try
            {
                if (user != null)
                {
                    var Token = GenerateToken(user);
                    return Token;
                }
            }
            catch (Exception ex)
            {
                throw new NotImplementedException();
            }
            return "";
        }

        public string GenerateToken(User user)
        {
            var userClaims = SetClaim(user);

            //var claims = userClaims;
            var key = new SymmetricSecurityKey(_jwtSettings.Key);
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                issuer: _jwtSettings.Issuer,
                audience: _jwtSettings.Audience,
                claims: userClaims,
                expires: DateTime.Now.AddMinutes(60),
                signingCredentials: creds
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public IEnumerable<Claim> SetClaim(User User)
        {
            List<Claim> claims = new List<Claim>();
            claims.Add(new Claim("UserId", User.UserId.ToString()));
            claims.Add(new Claim("Email", User.Email.ToString()));
            claims.Add(new Claim("ImageURl", User.Tenant.TenantImageURL != null ? User.Tenant.TenantImageURL.ToString() : ""));
            claims.Add(new Claim("TenantId", User.TenantId.ToString()));
            claims.Add(new Claim("TenantName", User.Tenant.TenantName.ToString()));
            claims.Add(new Claim("Language", User.Language.ToString()));
            return claims;
        }

    }
}
