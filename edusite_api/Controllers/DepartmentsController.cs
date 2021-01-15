using System.Collections.Generic;
using AutoMapper;
using Auth_API.Data.Contract;
//using Auth_API.Data.Mock;
using Auth_API.Dtos.Department;
using Auth_API.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Auth_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentRepo _repository;
        private readonly IMapper _mapper;

        public DepartmentsController(IDepartmentRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //Get  api/Departments
        [HttpGet]
        public ActionResult<IEnumerable<DepartmentReadDto>> GetAllDepartments()
        {
            var Departments = _repository.GetAll();
            return Ok(_mapper.Map<IEnumerable<DepartmentReadDto>>(Departments));
        }

        //Get  api/Departments/5
        [HttpGet("{id}", Name = "GetDepartmentById")]
        public ActionResult<DepartmentReadDto> GetDepartmentById(Guid id)
        {
            var Department = _repository.GetDepartmentById(id);
            if (Department != null)
            {

                return Ok(_mapper.Map<DepartmentReadDto>(Department));
            }
            return NotFound();
        }

        //Post  api/Departments
        [HttpPost]
        public ActionResult<DepartmentCreateDto> CreateDepartment(DepartmentCreateDto Department)
        {
            var DepartmentModel = _mapper.Map<Department>(Department);
            _repository.CreateDepartment(DepartmentModel);
            _repository.SaveChanges();

            var DepartmentReadDto = _mapper.Map<DepartmentReadDto>(DepartmentModel);

            return CreatedAtRoute(nameof(GetDepartmentById), new { id = DepartmentReadDto.DepartmentId }, DepartmentReadDto);
        }

        //put  api/Students/5
        [HttpPut("{id}")]
        public ActionResult UpdateStudent(Guid id, DepartmentUpdateDto Department)
        {
            var DepartmentFromDB = _repository.GetDepartmentById(id);
            if (DepartmentFromDB == null)
            {
                return NotFound();
            }
            _mapper.Map(Department, DepartmentFromDB);
            _repository.UpdateDepartment(DepartmentFromDB);
            _repository.SaveChanges();

            return NoContent();
        }

        //Delete  api/Departments/5
        [HttpDelete("{id}")]
        public ActionResult DeleteDepartment(Guid id)
        {
            var DepartmentFromDB = _repository.GetDepartmentById(id);
            if (DepartmentFromDB == null)
            {
                return NotFound();
            }

            _repository.DeleteDepartment(DepartmentFromDB);
            _repository.SaveChanges();

            return NoContent();
        }
    }

}