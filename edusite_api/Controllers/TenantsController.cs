using System.Collections.Generic;
using AutoMapper;
using Auth_API.Data.Contract;
//using Auth_API.Data.Mock;
using Auth_API.Dtos.Tenant;
using Auth_API.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Auth_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TenantsController : ControllerBase
    {
        private readonly ITenantRepo _repository;
        private readonly IMapper _mapper;

        public TenantsController(ITenantRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //Get  api/Tenants
        [HttpGet]
        public ActionResult<IEnumerable<TenantReadDto>> GetAllTenants()
        {
            var Tenants = _repository.GetAll();
            return Ok(_mapper.Map<IEnumerable<TenantReadDto>>(Tenants));
        }

        //Get  api/Tenants/5
        [HttpGet("{id}", Name = "GetTenantById")]
        public ActionResult<TenantReadDto> GetTenantById(Guid id)
        {
            var Tenant = _repository.GetTenantById(id);
            if (Tenant != null)
            {
                return Ok(_mapper.Map<TenantReadDto>(Tenant));
            }
            return NotFound();
        }

        //Post  api/Tenants
        [HttpPost]
        public ActionResult<TenantCreateDto> CreateTenant(TenantCreateDto Tenant)
        {
            var TenantModel = _mapper.Map<Tenant>(Tenant);
            _repository.CreateTenant(TenantModel);
            _repository.SaveChanges();

            var TenantReadDto = _mapper.Map<TenantReadDto>(TenantModel);

            return CreatedAtRoute(nameof(GetTenantById), new { id = TenantReadDto.TenantId }, TenantReadDto);
        }

        //put  api/Tenants/5
        [HttpPut("{id}")]
        public ActionResult UpdateTenant(Guid id, TenantUpdateDto Tenant)
        {
            var TenantFromDB = _repository.GetTenantById(id);
            if (TenantFromDB == null)
            {
                return NotFound();
            }
            _mapper.Map(Tenant, TenantFromDB);
            _repository.UpdateTenant(TenantFromDB);
            _repository.SaveChanges();

            return NoContent();
        }

        //Delete  api/Tenants/5
        [HttpDelete("{id}")]
        public ActionResult DeleteTenant(Guid id)
        {
            var TenantFromDB = _repository.GetTenantById(id);
            if (TenantFromDB == null)
            {
                return NotFound();
            }

            _repository.DeleteTenant(TenantFromDB);
            _repository.SaveChanges();

            return NoContent();
        }
    }

}