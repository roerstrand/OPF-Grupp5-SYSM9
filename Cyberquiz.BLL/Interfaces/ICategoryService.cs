using Cyberquiz.DAL.Models;

namespace Cyberquiz.BLL.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryModel>> GetAllCategoriesAsync(); //Behöver string username som paramater
        Task<CategoryModel?> GetCategoryByIdAsync(int id);

        Task<IEnumerable<SubCategoryModel>> GetAllSubCategoriesAsync();
        Task<SubCategoryModel?> GetSubCategoryByIdAsync(int id); //Behöver string username och int id som paramater
    }
}
