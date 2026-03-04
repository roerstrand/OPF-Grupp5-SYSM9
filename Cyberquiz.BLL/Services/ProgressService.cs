using Cyberquiz.BLL.Interfaces;
using Cyberquiz.DAL.Interface;
using Cyberquiz.DAL.Models;

namespace Cyberquiz.BLL.Services
{
    // Reglerar åtkomst
    // Använder ResultsService för att hämta information om användarens resultat
    public class ProgressService : IProgressService
    {
        // Injicerar IRepos
        private readonly IProgressRepository _progressRepo;
        private readonly IQuestionRepository _questionRepo;
        public ProgressService(IProgressRepository progressRepo, IQuestionRepository questionRepo)
        {
            _progressRepo = progressRepo;
            _questionRepo = questionRepo;
        }
        // Anropar metoder i Repos
        // Hämta underkategori för en användare
        public async Task<UserProgressModel?> GetByUserAndSubCategoryAsync(string userId, int subCategoryId)
        {
            return await _progressRepo.GetByUserAndSubCategoryAsync(userId, subCategoryId);
        }
        // Hämta alla underkategorier användaren klarat
        public async Task<IEnumerable<UserProgressModel>> GetAllByUserAsync(string userId)
        {
            return await _progressRepo.GetAllByUserAsync(userId);
        }
        // Spara användarens antal rätt och antal besvarade frågor
        public async Task SaveProgressAsync(UserProgressModel progress)
        {
            await _progressRepo.SaveProgressAsync(progress);
        }
        // Spara användarens svarsval
        public async Task SaveUserAnswerAsync(UserAnswerModel answer)
        {
            await _progressRepo.SaveUserAnswerAsync(answer);
        }
        // Hämta svarsalternativ för en underkategori
        public async Task<IEnumerable<UserAnswerModel>> GetAnswersByUserAndSubCategoryAsync(string userId, int subCategoryId)
        {
            return await _progressRepo.GetAnswersByUserAndSubCategoryAsync(userId, subCategoryId);
        }
        // Metod för att beräkna användarens procentuella resultat
        public async Task<double> CalculateSuccessRateAsync(string userId, int subCategoryId)
        {
            var answers = await _progressRepo
                .GetAnswersByUserAndSubCategoryAsync(userId, subCategoryId);

            if (!answers.Any())
                return 0;

            double correct = answers.Count(a => a.IsCorrect);
            double total = answers.Count();

            return (correct / total) * 100;
        }
        // Metod för att kontrollera användarens resultat i förhållande till vår uppsatta gräns för att öppna nästa underkategori
        public async Task<bool> IsSubCategoryCompletedAsync(string userId, int subCategoryId)
        {
            double successRate = await CalculateSuccessRateAsync(userId, subCategoryId);

            return successRate >= 80; // Gräns för att öppna nästa underkategori
        }
    }
}
