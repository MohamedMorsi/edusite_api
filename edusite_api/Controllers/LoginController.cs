using AutoMapper;
using edusite_api.Services.Contract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auth_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ILoginService _loginService;

        public LoginController(IMapper mapper, ILoginService loginService)
        {
            _mapper = mapper;
            _loginService = loginService;
        }

        //Get  api/UserLogin
        [HttpGet(Name = nameof(UserLogin))]
        public IActionResult UserLogin(string _UserName, string _password, bool rememberMe)
        {
            var user = _loginService.Login(_UserName, _password);
            if (user != null)
            {
                return Ok(user);
            }
            return NotFound();
        }

        //Get  api/GenerateToken
        [HttpGet(Name = nameof(GenerateToken))]
        public IActionResult GenerateToken(string _UserName, string _password)
        {
            var Token = _loginService.ReturnAccountToken(_UserName, _password);
            if (Token != null)
            {
                return Ok(Token);
            }
            return NotFound();
        }
    }
}
