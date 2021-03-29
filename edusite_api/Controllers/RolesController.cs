using System.Collections.Generic;
using AutoMapper;
using Auth_API.Data.Contract;
//using Auth_API.Data.Mock;
using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.AspNetCore.Authorization;
using Dtos.Role;

namespace Auth_API.Controllers
{
    [Authorize(Roles = "MasterAdmin")]
    [Route("V4/api/[controller]/[action]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly IRoleRepo _repository;
        private readonly IMapper _mapper;

        public RolesController(IRoleRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //Get  api/Users
        [HttpGet]
        public ActionResult<IEnumerable<RoleReadDto>> GetAllRoles()
        {
            var Roles = _repository.GetAll();
            return Ok(_mapper.Map<IEnumerable<RoleReadDto>>(Roles));
        }


    }

}