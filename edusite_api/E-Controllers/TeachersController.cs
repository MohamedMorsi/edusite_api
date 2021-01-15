using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using Dtos.Teacher;
using edusite_api.Data.Contract;

namespace edusite_api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        private readonly ITeacherRepo _repository;
        private readonly IMapper _mapper;

        public TeachersController(ITeacherRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //Get  api/Teachers
        [HttpGet]
        public ActionResult<IEnumerable<TeacherReadDto>> GetAllTeachers()
        {
            var Teachers = _repository.GetAll();
            return Ok(_mapper.Map<IEnumerable<TeacherReadDto>>(Teachers));
        }

        //Get  api/Teachers/5
        [HttpGet("{id}", Name = "GetTeacherById")]
        public ActionResult<TeacherReadDto> GetTeacherById(int id)
        {
            var Teacher = _repository.GetTeacherById(id);
            if (Teacher != null)
            {

                return Ok(_mapper.Map<TeacherReadDto>(Teacher));
            }
            return NotFound();
        }

        //Post  api/Teachers
        [HttpPost]
        public ActionResult<TeacherCreateDto> CreateTeacher(TeacherCreateDto Teacher)
        {
            var TeacherModel = _mapper.Map<Models.Teacher>(Teacher);
            _repository.CreateTeacher(TeacherModel);
            _repository.SaveChanges();

            var TeacherReadDto = _mapper.Map<TeacherReadDto>(TeacherModel);

            return CreatedAtRoute(nameof(GetTeacherById), new { id = TeacherReadDto.TeacherId }, TeacherReadDto);
        }

        //put  api/Teachers/5
        [HttpPut("{id}")]
        public ActionResult UpdateTeacher(int id, TeacherUpdateDto Teacher)
        {
            var TeacherFromDB = _repository.GetTeacherById(id);
            if (TeacherFromDB == null)
            {
                return NotFound();
            }
            _mapper.Map(Teacher, TeacherFromDB);
            _repository.UpdateTeacher(TeacherFromDB);
            _repository.SaveChanges();

            return NoContent();
        }

        //Delete  api/Teachers/5
        [HttpDelete("{id}")]
        public ActionResult DeleteTeacher(int id)
        {
            var TeacherFromDB = _repository.GetTeacherById(id);
            if (TeacherFromDB == null)
            {
                return NotFound();
            }

            _repository.DeleteTeacher(TeacherFromDB);
            _repository.SaveChanges();

            return NoContent();
        }
    }

}