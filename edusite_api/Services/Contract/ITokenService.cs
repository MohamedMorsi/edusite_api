using Auth_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Auth_API.Services.Contract
{
    public interface ITokenService
    {
        IEnumerable<Claim> SetClaim(User user);
        string GenerateUserToken(User user);
    }
}
