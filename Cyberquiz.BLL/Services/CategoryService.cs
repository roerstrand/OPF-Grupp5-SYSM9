using Cyberquiz.BLL.DummyFilesBLL;
using Cyberquiz.BLL.Interfaces;
using static Cyberquiz.BLL.DummyFilesBLL.DummyClassCollection;

namespace Cyberquiz.BLL.Services
{
    // Skapa kategoriöversikt (för UI)
    public class CategoryService : ICategoryService // Serviceklass implementerar Interface
    {
        // Använder ICategoryRepository för att hämta kategorier
        private readonly ICatRepo _categoryRepo;

        public CategoryService(
            ICatRepo categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }

        // Metod för att hämta kategorier
        public async Task<List<Category>> GetAllAsync()
        {
            return await _categoryRepo.GetAllAsync();
        }
        // Mappa till CategoryOverviewDto - SENARE 
    }
}
