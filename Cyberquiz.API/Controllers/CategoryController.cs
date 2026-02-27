using Cyberquiz.BLL.Interfaces;
using Cyberquiz.Shared.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Cyberquiz.API.Controllers
{
    [ApiController]
    [Route("/api/categories")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }


        ////GET: /api/categories
        //[HttpGet]
        //public async Task<ActionResult<List<CategoryDto>>> GetCategories()
        //{
        //    var categories = await _categoryService.GetAllAsync();
        //    return Ok(categories);


        //}



    }

}
