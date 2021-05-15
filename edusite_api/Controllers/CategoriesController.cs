using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using Dtos.Category;
using edusite_api.Data.Contract;

namespace edusite_api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepo _repository;
        private readonly IMapper _mapper;

        public CategoriesController(ICategoryRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //Get  api/Categories
        [HttpGet]
        public ActionResult<IEnumerable<CategoryReadDto>> GetAllCategories()
        {
            var Categories = _repository.GetAll();
            return Ok(_mapper.Map<IEnumerable<CategoryReadDto>>(Categories));
        }

        //Get  api/Categories/5
        [HttpGet("{id}", Name = "GetCategoryById")]
        public ActionResult<CategoryReadDto> GetCategoryById(int id)
        {
            var Category = _repository.GetCategoryById(id);
            if (Category != null)
            {

                return Ok(_mapper.Map<CategoryReadDto>(Category));
            }
            return NotFound();
        }

        //Post  api/Categories
        [HttpPost]
        public ActionResult<CategoryCreateDto> CreateCategory(CategoryCreateDto Category)
        {
            var CategoryModel = _mapper.Map<Models.Category>(Category);
            _repository.CreateCategory(CategoryModel);
            _repository.SaveChanges();

            var CategoryReadDto = _mapper.Map<CategoryReadDto>(CategoryModel);

            return CreatedAtRoute(nameof(GetCategoryById), new { id = CategoryReadDto.Id }, CategoryReadDto);
        }

        //put  api/Categories/5
        [HttpPut("{id}")]
        public ActionResult UpdateCategory(int id, CategoryUpdateDto Category)
        {
            var CategoryFromDB = _repository.GetCategoryById(id);
            if (CategoryFromDB == null)
            {
                return NotFound();
            }
            _mapper.Map(Category, CategoryFromDB);
            _repository.UpdateCategory(CategoryFromDB);
            _repository.SaveChanges();

            return NoContent();
        }

        //Delete  api/Categories/5
        [HttpDelete("{id}")]
        public ActionResult DeleteCategory(int id)
        {
            var CategoryFromDB = _repository.GetCategoryById(id);
            if (CategoryFromDB == null)
            {
                return NotFound();
            }

            _repository.DeleteCategory(CategoryFromDB);
            _repository.SaveChanges();

            return NoContent();
        }
    }

}