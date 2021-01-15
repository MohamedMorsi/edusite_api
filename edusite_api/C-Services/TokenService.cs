using edusite_api.Services.Contract;
using edusite_api.Setting;
using Microsoft.IdentityModel.Tokens;
using Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace edusite_api.Services
{
    public class TokenService : ITokenService
    {
        private readonly JwtSettings _jwtSettings;

        public TokenService(JwtSettings jwtSettings)
        {
            _jwtSettings = jwtSettings;
        }

        public string GenerateAccountUserToken(Account Account)
        {
            try
            {
                if (Account != null)
                {
                    var Token = GenerateToken(Account);
                    return Token;
                }
            }
            catch (Exception ex)
            {
                throw new NotImplementedException();
            }
            return "";
        }

        public string GenerateToken(Account Account)
        {
            var AccountClaims = SetClaim(Account);

            //var claims = userClaims;
            var key = new SymmetricSecurityKey(_jwtSettings.Key);
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                issuer: _jwtSettings.Issuer,
                audience: _jwtSettings.Audience,
                claims: AccountClaims,
                expires: DateTime.Now.AddMinutes(60),
                signingCredentials: creds
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public IEnumerable<Claim> SetClaim(Account Account)
        {
            List<Claim> claims = new List<Claim>();
            claims.Add(new Claim("UserId", Account.AccountId.ToString()));
            claims.Add(new Claim("Email", Account.UserEmail.ToString()));
            claims.Add(new Claim("Language", Account.Language.ToString()));
            return claims;
        }

    }
}
