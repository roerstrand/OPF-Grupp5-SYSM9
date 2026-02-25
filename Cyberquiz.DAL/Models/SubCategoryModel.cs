using System;
using System.Collections.Generic;
using System.Text;

namespace Cyberquiz.DAL.Models
{
    public class SubCategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string CategoryModelId { get; set; }

        public int QuestionModelId { get; set; }

    }
}
