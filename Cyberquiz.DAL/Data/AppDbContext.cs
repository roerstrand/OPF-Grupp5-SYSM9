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

        // Make these public DbSet properties so EF Core can discover the entity types
        public DbSet<CategoryModel> Categories { get; set; } = null!;

        public DbSet<SubCategoryModel> SubCategories { get; set; } = null!;

        public DbSet<QuestionAnswerModel> QuestionAnswers { get; set; } = null!;

        public DbSet<UserResultModel> UserResults { get; set; } = null!;

        public DbSet<QuestionModel> Questions { get; set; } = null!;

    }
}
