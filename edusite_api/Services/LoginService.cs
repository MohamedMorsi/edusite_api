using edusite_api.Data.Contract;
using edusite_api.Services.Contract;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace edusite_api.Services
{
    public class LoginService : ILoginService
    {
        private readonly IAccountRepo _Account;
        private readonly ITokenService _tokenService;
        public LoginService(IAccountRepo Account, ITokenService tokenService)
        {
            _Account = Account;
            _tokenService = tokenService;
        }
        public Account Login(string _userName, string _password)
        {
            try
            {
                //_password = EncryptUtils.Base64Encode(_password);
                var Account = _Account.GetAccountByUsernameAndPassword(_userName, _password);
                var Token = _tokenService.GenerateAccountUserToken(Account);

                return Account;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public string ReturnAccountToken(string _userName, string _password)
        {
            try
            {
                //_password = EncryptUtils.Base64Encode(_password);
                var Account = _Account.GetAccountByUsernameAndPassword(_userName, _password);
                var Token = _tokenService.GenerateAccountUserToken(Account);
                return Token;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
