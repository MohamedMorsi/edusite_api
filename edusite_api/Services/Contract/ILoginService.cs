using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace edusite_api.Services.Contract
{
    public interface ILoginService
    {
        Account Login(string _username, string _password);
        string ReturnAccountToken(string _userName, string _password);
    }
}
