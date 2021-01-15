using System.Collections.Generic;
using AutoMapper;
using Auth_API.Data.Contract;
//using Auth_API.Data.Mock;
using Auth_API.Dtos.Permission;
using Auth_API.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Auth_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PermissionsController : ControllerBase
    {
        private readonly IPermissionRepo _repository;
        private readonly IMapper _mapper;

        public PermissionsController(IPermissionRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //Get  api/Permissions
        [HttpGet]
        public ActionResult<IEnumerable<PermissionReadDto>> GetAllPermissions()
        {
            var Permissions = _repository.GetAll();
            return Ok(_mapper.Map<IEnumerable<PermissionReadDto>>(Permissions));
        }

        //Get  api/Permissions/5
        [HttpGet("{id}", Name = "GetPermissionById")]
        public ActionResult<PermissionReadDto> GetPermissionById(Guid id)
        {
            var Permission = _repository.GetPermissionById(id);
            if (Permission != null)
            {

                return Ok(_mapper.Map<PermissionReadDto>(Permission));
            }
            return NotFound();
        }

        //Post  api/Permissions
        [HttpPost]
        public ActionResult<PermissionCreateDto> CreatePermission(PermissionCreateDto Permission)
        {
            var PermissionModel = _mapper.Map<Permission>(Permission);
            _repository.CreatePermission(PermissionModel);
            _repository.SaveChanges();

            var PermissionReadDto = _mapper.Map<PermissionReadDto>(PermissionModel);

            return CreatedAtRoute(nameof(GetPermissionById), new { id = PermissionReadDto.PermissionId }, PermissionReadDto);
        }

        //put  api/Permissions/5
        [HttpPut("{id}")]
        public ActionResult UpdatePermission(Guid id, PermissionUpdateDto Permission)
        {
            var PermissionFromDB = _repository.GetPermissionById(id);
            if (PermissionFromDB == null)
            {
                return NotFound();
            }
            _mapper.Map(Permission, PermissionFromDB);
            _repository.UpdatePermission(PermissionFromDB);
            _repository.SaveChanges();

            return NoContent();
        }

        //Delete  api/Permissions/5
        [HttpDelete("{id}")]
        public ActionResult DeletePermission(Guid id)
        {
            var PermissionFromDB = _repository.GetPermissionById(id);
            if (PermissionFromDB == null)
            {
                return NotFound();
            }

            _repository.DeletePermission(PermissionFromDB);
            _repository.SaveChanges();

            return NoContent();
        }
    }

}