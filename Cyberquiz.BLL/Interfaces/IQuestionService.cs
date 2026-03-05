using Cyberquiz.DAL.Models;

namespace Cyberquiz.BLL.Interfaces
{
    public interface IQuestionService
    {
        Task<QuestionDto?> GetByIdAsync(int id);
        Task<IEnumerable<QuestionDto>> GetBySubCategoryAsync(int subCategoryId);
    }
}
