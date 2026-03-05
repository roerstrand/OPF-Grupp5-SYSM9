using Cyberquiz.Shared.DTOs;

namespace Cyberquiz.BLL.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDto>> GetAllCategoriesAsync();
        Task<CategoryDto?> GetCategoryByIdAsync(int id);

        Task<IEnumerable<SubCategoryModel>> GetAllSubCategoriesAsync();
        Task<SubCategoryModel?> GetSubCategoryByIdAsync(int id);
    }
}
