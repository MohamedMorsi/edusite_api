using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using Dtos.Plan;
using edusite_api.Data.Contract;

namespace edusite_api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PlansController : ControllerBase
    {
        private readonly IPlanRepo _repository;
        private readonly IMapper _mapper;

        public PlansController(IPlanRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //Get  api/Plans
        [HttpGet]
        public ActionResult<IEnumerable<PlanReadDto>> GetAllPlans()
        {
            var Plans = _repository.GetAll();
            return Ok(_mapper.Map<IEnumerable<PlanReadDto>>(Plans));
        }

        //Get  api/Plans/5
        [HttpGet("{id}", Name = "GetPlanById")]
        public ActionResult<PlanReadDto> GetPlanById(int id)
        {
            var Plan = _repository.GetPlanById(id);
            if (Plan != null)
            {

                return Ok(_mapper.Map<PlanReadDto>(Plan));
            }
            return NotFound();
        }

        //Post  api/Plans
        [HttpPost]
        public ActionResult<PlanCreateDto> CreatePlan(PlanCreateDto Plan)
        {
            var PlanModel = _mapper.Map<Models.Plan>(Plan);
            _repository.CreatePlan(PlanModel);
            _repository.SaveChanges();

            var PlanReadDto = _mapper.Map<PlanReadDto>(PlanModel);

            return CreatedAtRoute(nameof(GetPlanById), new { id = PlanReadDto.Id }, PlanReadDto);
        }

        //put  api/Plans/5
        [HttpPut("{id}")]
        public ActionResult UpdatePlan(int id, PlanUpdateDto Plan)
        {
            var PlanFromDB = _repository.GetPlanById(id);
            if (PlanFromDB == null)
            {
                return NotFound();
            }
            _mapper.Map(Plan, PlanFromDB);
            _repository.UpdatePlan(PlanFromDB);
            _repository.SaveChanges();

            return NoContent();
        }

        //Delete  api/Plans/5
        [HttpDelete("{id}")]
        public ActionResult DeletePlan(int id)
        {
            var PlanFromDB = _repository.GetPlanById(id);
            if (PlanFromDB == null)
            {
                return NotFound();
            }

            _repository.DeletePlan(PlanFromDB);
            _repository.SaveChanges();

            return NoContent();
        }
    }

}