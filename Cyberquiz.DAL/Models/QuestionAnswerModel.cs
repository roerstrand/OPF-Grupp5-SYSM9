using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Cyberquiz.DAL.Models
{
    public class QuestionAnswerModel
    {
        public int Id { get; set; }

        public string Answer { get; set; } = string.Empty;

        public QuestionModel QuestionId { get; set; }

    }
}

//Update-Database -Context AuthDbContext -Project CyberQuiz.DAL -StartupProject CyberQuiz.API