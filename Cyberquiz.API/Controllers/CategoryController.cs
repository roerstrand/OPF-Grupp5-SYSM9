using Cyberquiz.BLL.Interfaces;
using Cyberquiz.Shared.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cyberquiz.API.Controllers
{
    [ApiController]
    [Route("/api/categories")]
    [Authorize]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }


        //GET: /api/categories
        [HttpGet]
        public async Task<ActionResult<List<CategoryDto>>> GetCategories()
        {
            var categories = await _categoryService.GetCategoriesAsync(User.Identity?.Name ?? "user");
            return Ok(categories);

        }

        //// GET api/categories/{categoryId}/subcategories
        [HttpGet("{categoryId}/subcategories")]
        public async Task<ActionResult<List<SubCategoryDto>>> GetSubCategoriesByCategoryId(int categoryId)
        {
            var subCategories = await _categoryService.GetSubCategoriesByCategoryIdAsync(categoryId, User.Identity?.Name ?? "user");
            return Ok(subCategories);


        }

    }

}
