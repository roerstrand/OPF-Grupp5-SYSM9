using System;

namespace Cyberquiz.DAL.Models
{
    public class UserProgressModel
    {
        public int Id { get; set; }

        public string UserName { get; set; } = string.Empty;

        public int QuizId { get; set; }
        public QuizModel Quiz { get; set; }

        public int Score { get; set; }

        public int TotalQuestions { get; set; }

        public DateTime CompletedAt { get; set; }
    }
}
