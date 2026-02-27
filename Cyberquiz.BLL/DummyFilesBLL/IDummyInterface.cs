using System;
using System.Collections.Generic;
using System.Text;

namespace Cyberquiz.BLL.DummyFilesBLL
{
    public interface IDummyInterface
    {
        // Dummyvariabel i form av en lista 
        public List<string> Category { get; set; }

        public interface ICategoryRepository
        {
            Task<List<Category>> GetAllAsync();
            Task<Category?> GetByIdAsync(int id);
        }
        public interface ISubCategoryRepository
        {
            Task<SubCategory?> GetByIdAsync(int id);
            Task<List<SubCategory>> GetByCategoryIdAsync(int categoryId);
        }
        public interface IQuestionRepository
        {
            Task<List<Question>> GetBySubCategoryIdAsync(int subCategoryId);
        }
        public interface IAnswerOptionRepository
        {
            Task<AnswerOption?> GetByIdAsync(int id);
        }
        public interface IUserResultRepository
        {
            Task AddAsync(UserResult result);
            Task<UserResult?> GetLatestAsync(string userId, int subCategoryId);
            Task<List<UserResult>> GetByUserAsync(string userId);
        }
    }

    // Dummy-klasser
    public class Category { }
    public class SubCategory { }
    public class Question { }
    public class AnswerOption { }
    public class UserResult { }
}
