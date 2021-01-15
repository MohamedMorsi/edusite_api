using Auth_API.Data.Contract;
using Auth_API.Models;
using Auth_API.Services.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auth_API.Services
{
    public class LoginService : ILoginService
    {
        private readonly IUserRepo _user;
        private readonly ICurrentActiveUserRepo _CurrentActiveUser;
        private readonly ITokenService _tokenService;
        public LoginService(IUserRepo user, ICurrentActiveUserRepo CurrentActiveUser, ITokenService tokenService)
        {
            _user = user;
            _CurrentActiveUser = CurrentActiveUser;
            _tokenService = tokenService;
        }
        public User Login(string _userName, string _password)
        {
            try
            {
                //_password = EncryptUtils.Base64Encode(_password);
                var user = _user.GetUserByUsernameAndPassword(_userName, _password);
                var Token = _tokenService.GenerateUserToken(user);
                var CurrentActiveUser = new CurrentActiveUser
                {
                    CurrentActiveUserId = new Guid(),
                    UserId = user.UserId,
                    TenantId = user.TenantId,
                    UserToken = Token
                };
                _CurrentActiveUser.CreateCurrentActiveUser(CurrentActiveUser);
                _CurrentActiveUser.SaveChanges();
                return user;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public string ReturnUserToken(string _userName, string _password)
        {
            try
            {
                //_password = EncryptUtils.Base64Encode(_password);
                var user = _user.GetUserByUsernameAndPassword(_userName, _password);
                var Token = _tokenService.GenerateUserToken(user);
                return Token;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
