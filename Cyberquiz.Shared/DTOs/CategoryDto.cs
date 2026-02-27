using System;
using System.Collections.Generic;
using System.Text;

namespace Cyberquiz.Shared.DTOs
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; //Visar Categoryn namn 

        //public int QuestionId { get; set; }
        //public int SubCategoryId { get; set; }
        //public QuestionModel QuestionId { get; set; }

        //public SubCategoryModel SubCategoryId { get; set; }
    }
}
