using Cyberquiz.Shared.DTOs;

namespace Cyberquiz.BLL.Interfaces
{
    public interface IQuestionService
    {
        Task<QuestionDto?> GetQuestionByIdAsync(int questionId);
        //Task<IEnumerable<QuestionDto>> GetQuestionBySubCategoryAsync(int subCategoryId); // METOD ANVÄNDS INTE I NUVARANDE VERSION
        Task<QuestionDto?> GetNextQuestionInSubCategoryAsync(int subCategoryId); // hämtar nästa fråga som användaren inte har svarat på i den subkategorin
        Task<SubmitResponseDto> SaveUserAnswerAsync(SubmitAnswerRequestDto request); //tar emot användarens svar, sparar det och returnerar om det var rätt eller fel
    }
}
