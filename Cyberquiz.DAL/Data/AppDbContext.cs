using System;
using System.Collections.Generic;
using System.Text;
using Cyberquiz.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Cyberquiz.DAL.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        private DbSet<CategoryModel>? Categories;

        private DbSet<SubCategoryModel> SubCategories;

        private DbSet<QuestionAnswerModel> QuestionAnswers;

        private DbSet<UserResultModel> UserResults;

        private DbSet<QuestionModel> Questions;

    }
}
