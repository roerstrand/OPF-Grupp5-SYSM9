using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Cyberquiz.DAL.Models
{
    public class SubCategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection <CategoryModel> CategoryModelId { get; set; }

        public ICollection <QuestionModel> QuestionModelId { get; set; }
        
    }
}
