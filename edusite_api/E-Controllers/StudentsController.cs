using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using Dtos.Student;
using edusite_api.Data.Contract;

namespace edusite_api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentRepo _repository;
        private readonly IMapper _mapper;

        public StudentsController(IStudentRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //Get  api/Students
        [HttpGet]
        public ActionResult<IEnumerable<StudentReadDto>> GetAllStudents()
        {
            var Students = _repository.GetAll();
            return Ok(_mapper.Map<IEnumerable<StudentReadDto>>(Students));
        }

        //Get  api/Students/5
        [HttpGet("{id}", Name = "GetStudentById")]
        public ActionResult<StudentReadDto> GetStudentById(int id)
        {
            var Student = _repository.GetStudentById(id);
            if (Student != null)
            {

                return Ok(_mapper.Map<StudentReadDto>(Student));
            }
            return NotFound();
        }

        //Post  api/Students
        [HttpPost]
        public ActionResult<StudentCreateDto> CreateStudent(StudentCreateDto Student)
        {
            var StudentModel = _mapper.Map<Models.Student>(Student);
            _repository.CreateStudent(StudentModel);
            _repository.SaveChanges();

            var StudentReadDto = _mapper.Map<StudentReadDto>(StudentModel);

            return CreatedAtRoute(nameof(GetStudentById), new { id = StudentReadDto.StudentId }, StudentReadDto);
        }

        //put  api/Students/5
        [HttpPut("{id}")]
        public ActionResult UpdateStudent(int id, StudentUpdateDto Student)
        {
            var StudentFromDB = _repository.GetStudentById(id);
            if (StudentFromDB == null)
            {
                return NotFound();
            }
            _mapper.Map(Student, StudentFromDB);
            _repository.UpdateStudent(StudentFromDB);
            _repository.SaveChanges();

            return NoContent();
        }

        //Delete  api/Students/5
        [HttpDelete("{id}")]
        public ActionResult DeleteStudent(int id)
        {
            var StudentFromDB = _repository.GetStudentById(id);
            if (StudentFromDB == null)
            {
                return NotFound();
            }

            _repository.DeleteStudent(StudentFromDB);
            _repository.SaveChanges();

            return NoContent();
        }
    }

}