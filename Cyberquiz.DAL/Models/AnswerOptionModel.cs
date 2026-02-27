using System;
using System.Collections.Generic;
using System.Text;

namespace Cyberquiz.DAL.Models
{

    // En modell (enskild entitet) som representerar ett svarsalternativ i databasen.
    public class AnswerOptionModel
    {
        public int Id { get; set; }

        public string Answer { get; set; } = string.Empty;

        public ICollection<QuestionAnswerOptionModel> QuestionAnswerOptions { get; set; }
    }
}
