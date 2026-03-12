using System;
using System.Collections.Generic;
using System.Text;

namespace Cyberquiz.BLL.Interfaces
{
    public interface IAiCoachService
    {
        Task<AiFeedbackDto> GetUserAnalysisAsync(string userId);
    }
}
