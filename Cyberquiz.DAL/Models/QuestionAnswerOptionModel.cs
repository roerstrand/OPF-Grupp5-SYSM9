using System;
using System.Collections.Generic;
using System.Text;

namespace Cyberquiz.DAL.Models
{
    // Kopplingstabell: kopplar en fråga till ett svarsalternativ. På raden där questionId och AnswerOptionsid kopplas ihop markeras om det är rätt svar
    public class QuestionAnswerOptionModel
    {
        public int QuestionId { get; set; }
        public QuestionModel Question { get; set; }

        public int AnswerOptionId { get; set; }
        public AnswerOptionModel AnswerOption { get; set; }

        public bool IsCorrect { get; set; }
    }
}
