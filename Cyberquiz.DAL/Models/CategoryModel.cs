using System;
using System.Collections.Generic;
using System.Text;

namespace Cyberquiz.DAL.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public ICollection<QuestionModel> QuestionId { get; set; }

        public ICollection<SubCategoryModel> SubCategoryId { get; set; }
    }
}
