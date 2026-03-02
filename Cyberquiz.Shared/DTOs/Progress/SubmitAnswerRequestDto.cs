using System;
using System.Collections.Generic;
using System.Text;

namespace Cyberquiz.Shared.DTOs.Progress
{
    public class SubmitAnswerRequestDto
    {
        public int SubCategoryId { get; set; }
        public int QuestionId { get; set; }
        public int AnswerOptionId { get; set; }
    }
}
