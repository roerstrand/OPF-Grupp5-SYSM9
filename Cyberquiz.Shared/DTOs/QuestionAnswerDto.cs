using System;
using System.Collections.Generic;
using System.Text;

namespace Cyberquiz.Shared.DTOs
{
    public class QuestionAnswerDto
    {
        public int Id { get; set; }

        public string Answer { get; set; } = string.Empty;

        //public int QuestionId { get; set; }
        //public string QuestionAnswer { get; set; }
        //public QuestionModel QuestionId { get; set; }
    }
}
