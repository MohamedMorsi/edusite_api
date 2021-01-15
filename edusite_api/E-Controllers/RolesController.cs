using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using Dtos.Role;
using edusite_api.Data.Contract;

namespace edusite_api.Controllers
{
    [Route("api/[controller]/[action]")]
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

        //Get  api/Roles
        [HttpGet]
        public ActionResult<IEnumerable<RoleReadDto>> GetAllRoles()
        {
            var Roles = _repository.GetAll();
            return Ok(_mapper.Map<IEnumerable<RoleReadDto>>(Roles));
        }

        //Get  api/Roles/5
        [HttpGet("{id}", Name = "GetRoleById")]
        public ActionResult<RoleReadDto> GetRoleById(int id)
        {
            var Role = _repository.GetRoleById(id);
            if (Role != null)
            {

                return Ok(_mapper.Map<RoleReadDto>(Role));
            }
            return NotFound();
        }

        //Post  api/Roles
        [HttpPost]
        public ActionResult<RoleCreateDto> CreateRole(RoleCreateDto Role)
        {
            var RoleModel = _mapper.Map<Models.Role>(Role);
            _repository.CreateRole(RoleModel);
            _repository.SaveChanges();

            var RoleReadDto = _mapper.Map<RoleReadDto>(RoleModel);

            return CreatedAtRoute(nameof(GetRoleById), new { id = RoleReadDto.RoleId }, RoleReadDto);
        }

        //put  api/Roles/5
        [HttpPut("{id}")]
        public ActionResult UpdateRole(int id, RoleUpdateDto Role)
        {
            var RoleFromDB = _repository.GetRoleById(id);
            if (RoleFromDB == null)
            {
                return NotFound();
            }
            _mapper.Map(Role, RoleFromDB);
            _repository.UpdateRole(RoleFromDB);
            _repository.SaveChanges();

            return NoContent();
        }

        //Delete  api/Roles/5
        [HttpDelete("{id}")]
        public ActionResult DeleteRole(int id)
        {
            var RoleFromDB = _repository.GetRoleById(id);
            if (RoleFromDB == null)
            {
                return NotFound();
            }

            _repository.DeleteRole(RoleFromDB);
            _repository.SaveChanges();

            return NoContent();
        }
    }

}