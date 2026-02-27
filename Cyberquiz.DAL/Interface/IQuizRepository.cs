using Cyberquiz.DAL.Models;

namespace Cyberquiz.DAL.Interface
{
    public interface IQuizRepository
    {
        // Hämtar alla quizar (utan frågor/svar — för listvy)
        Task<IEnumerable<QuizModel>> GetAllAsync();

        // Hämtar ett quiz med alla frågor och svarsalternativ (för gameplay)
        Task<QuizModel?> GetByIdAsync(int id);

        // Hämtar användarens sparade resultat för en specifik subkategori
        // Används av BLL för att avgöra om 80%-kravet är uppfyllt (Score / TotalQuestions >= 0.80)
        Task<UserProgressModel?> GetUserProgressAsync(string userName, int subCategoryId);
    }
}
