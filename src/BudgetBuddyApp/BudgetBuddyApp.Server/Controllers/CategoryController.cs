using BudgetBuddyApp.Server.DTOs.CategoryDTOs;
using BudgetBuddyApp.Server.Interfaces.Services;
using BudgetBuddyApp.Server.Utils;
using Microsoft.AspNetCore.Mvc;

namespace BudgetBuddyApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("user/{userId}")]
        public async Task<IActionResult> GetCategoriesByUserId(Guid userId)
        {
            try
            {
                var categories = await _categoryService.GetCategoriesByUserIdAsync(userId);
                return Ok(categories);
            }
            catch (Exception ex)
            {
                return StatusCode(500, Constants.ServerErrorMessage);
            }
            
        }

        // GET: api/categories/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryById(Guid id)
        {
            try
            {
                var category = await _categoryService.GetCategoryByIdAsync(id);
                if (category == null)
                    return NotFound();

                return Ok(category);
            }
            catch (Exception ex)
            {
                return StatusCode(500, Constants.ServerErrorMessage);
            }
        }

        // POST: api/categories
        [HttpPost]
        public async Task<IActionResult> AddCategory([FromBody] AddCategoryDTO category)
        {
            try
            {
                if (!ModelState.IsValid)
                return BadRequest(ModelState);

                var newCategory = await _categoryService.AddCategoryAsync(category);
                return CreatedAtAction(nameof(GetCategoryById), new { id = newCategory.Id }, newCategory);
            }
            catch (Exception ex)
            {
                return StatusCode(500, Constants.ServerErrorMessage);
            }
            
        }
    }
}
