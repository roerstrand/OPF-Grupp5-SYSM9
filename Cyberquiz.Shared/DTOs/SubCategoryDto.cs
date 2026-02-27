using System;
using System.Collections.Generic;
using System.Text;

namespace Cyberquiz.Shared.DTOs
{
    public class SubCategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; } //Visar SubCategoryn namn
        public string CategoryName { get; set; } //Visar Categoryn namn i SubCategoryn

        //public string CategoryModelId { get; set; }

        //public int QuestionModelId { get; set; }
    }
}
