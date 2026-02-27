using Cyberquiz.DAL.Data;
using Cyberquiz.DAL.Interface;
using Cyberquiz.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Cyberquiz.DAL.Repositories
{
    public class QuizRepository : IQuizRepository
    {
        private readonly AppDbContext _context;

        public QuizRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<QuizModel>> GetAllAsync()
        {
            //AsNoTracking sparar prestanda när data enbart ska hämtas och ej sparas i DB
            return await _context.Quizzes
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<QuizModel?> GetByIdAsync(int id)
        {
            return await _context.Quizzes
                .AsNoTracking()
                .Include(q => q.Questions)
                    .ThenInclude(q => q.QuestionAnswerOptions)
                        .ThenInclude(qao => qao.AnswerOption)
                .FirstOrDefaultAsync(q => q.Id == id);
        }

        // Hämtar användarens sparade resultat för en specifik subkategori.
        // BLL använder detta för att kontrollera om Score / TotalQuestions >= 0.80
        // innan nästa subkategori låses upp.
        public async Task<UserProgressModel?> GetUserProgressAsync(string userName, int subCategoryId)
        {
            return await _context.UserProgress
                .AsNoTracking()
                .FirstOrDefaultAsync(up => up.UserName == userName && up.SubCategoryId == subCategoryId);
        }
    }
}
