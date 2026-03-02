using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Cyberquiz.Shared.DTOs;
using Cyberquiz.Shared.DTOs.Progress;

namespace Cyberquiz.BLL.Interfaces
{
    public interface IQuizService
    {
        Task<List<QuestionDto>> GetQuestionsBySubCategoryAsync(int subCategoryId, string userId);
        Task<QuizDto> StartQuizAsync(int subCategoryId, string userId);
        Task<SubmitResponseDto> SubmitAnswerRequestAsync(string userId, int questionId, int selectedOptionId);
    }
}
