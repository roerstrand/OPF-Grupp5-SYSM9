using System;

namespace Cyberquiz.Shared.DTOs
{
    public class UserAnswerDto
    {
        public int Id { get; set; }

        public string UserName { get; set; } = string.Empty;

        public int QuestionId { get; set; }

        public int AnswerOptionId { get; set; }

        public bool IsCorrect { get; set; }

        public DateTime AnsweredAt { get; set; }
    }
}
