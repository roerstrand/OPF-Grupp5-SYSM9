using Cyberquiz.Shared.DTOs;

namespace Cyberquiz.BLL.Interfaces
{
    public interface IQuestionService
    {
        Task<QuestionDto?> GetQuestionByIdAsync(int questionId);
        //Task<IEnumerable<QuestionDto>> GetQuestionBySubCategoryAsync(int subCategoryId, string userName); // METOD ANVÄNDS INTE I NUVARANDE VERSION
        Task<QuestionDto?> GetNextQuestionInSubCategoryAsync(int subCategoryId, string userName); // hämtar nästa fråga som användaren inte har svarat på i den subkategorin
        Task<(bool IsCorrect, int CorrectAnswerOptionId)> ValidateAnswerAsync(int questionId, int answerOptionId); // Metod för validering av svar
    }
}
