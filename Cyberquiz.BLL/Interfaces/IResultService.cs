using System;
using System.Collections.Generic;
using System.Text;

namespace Cyberquiz.BLL.Interfaces
{
    public interface IResultService // Interface för kontrakt med Service
    {
        Task<bool> SubmitAnswerAsync(string userId, int questionId, int selectedOptionId);
    }
}
