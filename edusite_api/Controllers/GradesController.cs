using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using Dtos.Grade;
using edusite_api.Data.Contract;

namespace edusite_api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class GradesController : ControllerBase
    {
        private readonly IGradeRepo _repository;
        private readonly IMapper _mapper;

        public GradesController(IGradeRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //Get  api/Grades
        [HttpGet]
        public ActionResult<IEnumerable<GradeReadDto>> GetAllGrades()
        {
            var Grades = _repository.GetAll();
            return Ok(_mapper.Map<IEnumerable<GradeReadDto>>(Grades));
        }

        //Get  api/Grades/5
        [HttpGet("{id}", Name = "GetGradeById")]
        public ActionResult<GradeReadDto> GetGradeById(int id)
        {
            var Grade = _repository.GetGradeById(id);
            if (Grade != null)
            {

                return Ok(_mapper.Map<GradeReadDto>(Grade));
            }
            return NotFound();
        }

        //Post  api/Grades
        [HttpPost]
        public ActionResult<GradeCreateDto> CreateGrade(GradeCreateDto Grade)
        {
            var GradeModel = _mapper.Map<Models.Grade>(Grade);
            _repository.CreateGrade(GradeModel);
            _repository.SaveChanges();

            var GradeReadDto = _mapper.Map<GradeReadDto>(GradeModel);

            return CreatedAtRoute(nameof(GetGradeById), new { id = GradeReadDto.GradeId }, GradeReadDto);
        }

        //put  api/Grades/5
        [HttpPut("{id}")]
        public ActionResult UpdateGrade(int id, GradeUpdateDto Grade)
        {
            var GradeFromDB = _repository.GetGradeById(id);
            if (GradeFromDB == null)
            {
                return NotFound();
            }
            _mapper.Map(Grade, GradeFromDB);
            _repository.UpdateGrade(GradeFromDB);
            _repository.SaveChanges();

            return NoContent();
        }

        //Delete  api/Grades/5
        [HttpDelete("{id}")]
        public ActionResult DeleteGrade(int id)
        {
            var GradeFromDB = _repository.GetGradeById(id);
            if (GradeFromDB == null)
            {
                return NotFound();
            }

            _repository.DeleteGrade(GradeFromDB);
            _repository.SaveChanges();

            return NoContent();
        }
    }

}