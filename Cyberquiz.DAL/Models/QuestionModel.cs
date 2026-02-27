using System;
using System.Collections.Generic;
using System.Text;

namespace Cyberquiz.DAL.Models
{
    public class QuestionModel
    {
        public int Id { get; set; }

        public string Question { get; set; }

        public ICollection<QuestionAnswerOptionModel> QuestionAnswerOptions { get; set; }

        public ICollection<QuizModel> Quizzes { get; set; }

        public ICollection<CategoryModel> CategoryId { get; set; }

        public ICollection<SubCategoryModel> SubCategoryId { get; set; }
    }
}
