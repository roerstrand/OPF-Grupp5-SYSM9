using Cyberquiz.BLL.Interfaces;
using Cyberquiz.DAL.Interface;
using Cyberquiz.DAL.Models;

namespace Cyberquiz.BLL.Services
{
    public class CategoryService : ICategoryService
    {
        // Injicerar IRepo
        private readonly ICategoryRepository _categoryRepo;
        public CategoryService(ICategoryRepository categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }

        // Anropar metoder i Repos
        // Hämta alla kategorier
        public async Task<IEnumerable<CategoryModel>> GetAllCategoriesAsync()
        {
            return await _categoryRepo.GetAllCategoriesAsync();
        }
        // Hämta en kategori
        public async Task<CategoryModel?> GetCategoryByIdAsync(int id)
        {
            return await _categoryRepo.GetCategoryByIdAsync(id);
        }
        // Hämta alla underkategorier
        public async Task<IEnumerable<SubCategoryModel>> GetAllSubCategoriesAsync()
        {
            return await _categoryRepo.GetAllSubCategoriesAsync();
        }
        // Hämta en underkategori
        public async Task<SubCategoryModel?> GetSubCategoryByIdAsync(int id)
        {
            return await _categoryRepo.GetSubCategoryByIdAsync(id);
        }
    }
}