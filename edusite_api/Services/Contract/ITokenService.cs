using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace edusite_api.Services.Contract
{
    public interface ITokenService
    {
        IEnumerable<Claim> SetClaim(Account Account);
        string GenerateAccountUserToken(Account Account);
    }
}
