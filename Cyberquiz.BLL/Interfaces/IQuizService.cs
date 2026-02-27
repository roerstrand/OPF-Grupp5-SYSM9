using System;
using System.Collections.Generic;
using System.Text;

namespace Cyberquiz.BLL.Interfaces
{
    public interface IQuizService // Interface för kontrakt med Service
    {
        Task<QuizDto> StartQuizAsync(int subCategoryId, string userId);
        Task<QuizResultDto> SubmitAnswerAsync(SubmitAnswerDto dto, string userId);
        Task SaveFinalResultAsync(FinalResultDto dto, string userId);
    }
}
