using Cyberquiz.BLL.Interfaces;
using Cyberquiz.DAL.Models;
using Cyberquiz.DAL.Interface;

namespace Cyberquiz.BLL.Services
{
    public class QuestionService : IQuestionService
    {
        // Injicerar IRepo
        private readonly IQuestionRepository _questionRepo;
        public QuestionService(IQuestionRepository questionRepo)
        {
            _questionRepo = questionRepo;
        }
        // Anropar metoder i Repo
        // Hämta en fråga
        public async Task<QuestionModel?> GetByIdAsync(int id)
        {
            return await _questionRepo.GetByIdAsync(id);
        }
        // Hämta frågans underkategori
        public async Task<IEnumerable<QuestionModel>> GetBySubCategoryAsync(int subCategoryId)
        {
            return await _questionRepo.GetBySubCategoryAsync(subCategoryId);
        }
    }
}
