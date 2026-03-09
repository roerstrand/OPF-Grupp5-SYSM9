using Cyberquiz.DAL.Models;

namespace Cyberquiz.DAL.Interface
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<CategoryModel>> GetAllCategoriesAsync(); // Behöver userName som parameter också
        Task<CategoryModel?> GetCategoryByIdAsync(int id); // Behöver userName som parameter också
        Task<IEnumerable<SubCategoryModel>> GetAllSubCategoriesAsync();
        Task<SubCategoryModel?> GetSubCategoryByIdAsync(int id);
    }
}
