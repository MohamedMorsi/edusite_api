using Auth_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auth_API.Services.Contract
{
    public interface ILoginService
    {
        User Login(string _username, string _password);
        string ReturnUserToken(string _userName, string _password);
    }
}
