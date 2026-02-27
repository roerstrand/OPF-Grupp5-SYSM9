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

        public DbSet<CategoryModel> Categories { get; set; } = null!;

        public DbSet<SubCategoryModel> SubCategories { get; set; } = null!;

        public DbSet<AnswerOptionModel> AnswerOptions { get; set; } = null!;

        public DbSet<QuestionAnswerOptionModel> QuestionAnswerOptions { get; set; } = null!;

        public DbSet<QuizModel> Quizzes { get; set; } = null!;

        public DbSet<UserProgressModel> UserProgress { get; set; } = null!;

        public DbSet<QuestionModel> Questions { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Explicit junction entity med payload (IsCorrect)
            modelBuilder.Entity<QuestionAnswerOptionModel>()
                .HasKey(x => new { x.QuestionId, x.AnswerOptionId });

            modelBuilder.Entity<QuestionAnswerOptionModel>()
                .HasOne(x => x.Question)
                .WithMany(q => q.QuestionAnswerOptions)
                .HasForeignKey(x => x.QuestionId);

            modelBuilder.Entity<QuestionAnswerOptionModel>()
                .HasOne(x => x.AnswerOption)
                .WithMany(a => a.QuestionAnswerOptions)
                .HasForeignKey(x => x.AnswerOptionId);

            // Quiz ↔ Question: automatisk many-to-many (ingen payload, EF skapar shadow join-tabell)
            modelBuilder.Entity<QuizModel>()
                .HasMany(q => q.Questions)
                .WithMany(q => q.Quizzes);
        }
    }
}
