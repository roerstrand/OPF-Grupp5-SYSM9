using System;
using System.Collections.Generic;
using System.Text;

namespace Cyberquiz.Shared.DTOs
{
    public class AnswerValidationDto
    {
        public bool IsCorrect { get; set; }
        public int CorrectAnswerOptionId { get; set; }

    }
}
