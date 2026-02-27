using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cyberquiz.DAL.Models
{
    public class UserResultModel
    {
        public int Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public int Score { get; set; }
        public DateTime Date { get; set; }
    }
}

//Add-Migration InitialCreate  -Context AppDbContext -Project CyberQuiz.DAL -StartupProject CyberQuiz.API