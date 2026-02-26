using Cyberquiz.DAL.Migrations;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Cyberquiz.DAL.Models
{
    public class QuestionModel
    {
        public int Id { get; set; }

        public string Question { get; set; }

        public ICollection<QuestionAnswerModel> QuestionAnswer { get; set; }

        public ICollection<CategoryModel> CategoryId { get; set; }

        public ICollection<SubCategoryModel> SubCategoryId { get; set; }
    }
}

//Add-Migration InitialCreate -Context AuthDbContext -Project CyberQuiz.DAL -StartupProject CyberQuiz.API