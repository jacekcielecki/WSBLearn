﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WSBLearn.Application.Constants;
using WSBLearn.Application.Dtos;
using WSBLearn.Application.Interfaces;
using WSBLearn.Application.Requests;
using WSBLearn.Domain.Entities;

namespace WSBLearn.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        // POST api/<CategoryController>
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult Create([FromBody] CreateCategoryRequest createCategoryRequest)
        {
            var result = _categoryService.Create(createCategoryRequest);

            return Created("Success", string.Format(CrudMessages.CreateEntitySuccess, "Category", result));
        }

        // GET: api/<CategoryController>
        [HttpGet]
        [AllowAnonymous]
        public ActionResult<IEnumerable<CategoryDto>> GetAll()
        {
            IEnumerable<CategoryDto>? categories =  _categoryService.GetAll();

            return Ok(categories);
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        [AllowAnonymous]
        public ActionResult<CategoryDto> GetById(int id)
        {
            CategoryDto category = _categoryService.GetById(id);

            return Ok(category);
        }

        // PUT api/<CategoryController>/5
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public ActionResult<CategoryDto> Update(int id, [FromBody] UpdateCategoryRequest updateCategoryRequest)
        {
            CategoryDto category = _categoryService.Update(id, updateCategoryRequest);

            return Ok(category);
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int id)
        {
            _categoryService.Delete(id);

            return Ok(string.Format(CrudMessages.DeleteEntitySuccess, "Category"));
        }
    }
}
