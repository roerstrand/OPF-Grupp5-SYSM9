using System;
using System.Collections.Generic;
using System.Text;

namespace Cyberquiz.DAL.Models
{
    public class QuestionAnswerModel
    {
        public int Id { get; set; }

        public string Answer { get; set; } = string.Empty;

        public QuestionModel QuestionId { get; set; }

    }
}
