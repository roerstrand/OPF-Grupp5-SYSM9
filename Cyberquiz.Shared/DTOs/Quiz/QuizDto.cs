using System;
using System.Collections.Generic;
using System.Text;

namespace Cyberquiz.Shared.DTOs
{
    public class QuizDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public ICollection<QuestionDto> Questions { get; set; }

        public int? SubCategoryId { get; set; }

        public string SubCategoryName { get; set; } = string.Empty;
    }
}
