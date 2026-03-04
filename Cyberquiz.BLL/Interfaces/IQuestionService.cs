using Cyberquiz.DAL.Models;
using Cyberquiz.Shared.DTOs;
using Cyberquiz.Shared.DTOs.Progress;

namespace Cyberquiz.BLL.Interfaces
{
    public interface IQuestionService
    {
        Task<QuestionModel?> GetByIdAsync(int id);
        Task<IEnumerable<QuestionModel>> GetBySubCategoryAsync(int subCategoryId);

        //Behövs
        //Task<QuestionDto?> GetNextQuestionAsync(string userName, int subCategoryId);
        //Task<SubmitResponseDto> SubmitAnswerAsync(string userName, SubmitAnswerRequestDto request);
    }
}
