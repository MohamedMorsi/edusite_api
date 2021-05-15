using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using Dtos.Course;
using edusite_api.Data.Contract;

namespace edusite_api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseRepo _repository;
        private readonly IMapper _mapper;

        public CoursesController(ICourseRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //Get  api/Courses
        [HttpGet]
        public ActionResult<IEnumerable<CourseReadDto>> GetAllCourses()
        {
            var Courses = _repository.GetAll();
            return Ok(_mapper.Map<IEnumerable<CourseReadDto>>(Courses));
        }

        //Get  api/Courses/5
        [HttpGet("{id}", Name = "GetCourseById")]
        public ActionResult<CourseReadDto> GetCourseById(int id)
        {
            var Course = _repository.GetCourseById(id);
            if (Course != null)
            {

                return Ok(_mapper.Map<CourseReadDto>(Course));
            }
            return NotFound();
        }

        //Post  api/Courses
        [HttpPost]
        public ActionResult<CourseCreateDto> CreateCourse(CourseCreateDto Course)
        {
            var CourseModel = _mapper.Map<Models.Course>(Course);
            _repository.CreateCourse(CourseModel);
            _repository.SaveChanges();

            var CourseReadDto = _mapper.Map<CourseReadDto>(CourseModel);

            return CreatedAtRoute(nameof(GetCourseById), new { id = CourseReadDto.Id }, CourseReadDto);
        }

        //put  api/Courses/5
        [HttpPut("{id}")]
        public ActionResult UpdateCourse(int id, CourseUpdateDto Course)
        {
            var CourseFromDB = _repository.GetCourseById(id);
            if (CourseFromDB == null)
            {
                return NotFound();
            }
            _mapper.Map(Course, CourseFromDB);
            _repository.UpdateCourse(CourseFromDB);
            _repository.SaveChanges();

            return NoContent();
        }

        //Delete  api/Courses/5
        [HttpDelete("{id}")]
        public ActionResult DeleteCourse(int id)
        {
            var CourseFromDB = _repository.GetCourseById(id);
            if (CourseFromDB == null)
            {
                return NotFound();
            }

            _repository.DeleteCourse(CourseFromDB);
            _repository.SaveChanges();

            return NoContent();
        }
    }

}