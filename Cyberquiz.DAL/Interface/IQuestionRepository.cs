using Cyberquiz.DAL.Models;

namespace Cyberquiz.DAL.Interface
{
    public interface IQuestionRepository
    {
        // Hämtar en enskild fråga med svarsalternativ
        Task<QuestionModel?> GetByIdAsync(int id);

        // Hämtar alla frågor som tillhör en specifik subkategori
        Task<IEnumerable<QuestionModel>> GetBySubCategoryAsync(int subCategoryId);
    }
}
