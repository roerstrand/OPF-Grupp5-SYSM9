using System;
using System.Collections.Generic;
using System.Text;

namespace Cyberquiz.DAL.Models
{
    public class QuestionModel
    {
        public int Id { get; set; }

        public string Question { get; set; }

        public QuestionAnswerModel QuestionAnswer { get; set; }

        public CategoryModel CategoryId { get; set; }

        public SubCategoryModel SubCategoryId { get; set; }
    }
}
