using Cyberquiz.BLL.DummyFilesBLL;
using Cyberquiz.BLL.Interfaces;
using static Cyberquiz.BLL.DummyFilesBLL.DummyClassCollection;

namespace Cyberquiz.BLL.Services
{
    // Hanterar användarnas framgång
    // Spara resultat
    // Hämta senaste resultat
    // Hämta historik
    // Räkna genomsnitt
    // Räkna procent
    public class ResultService : IResultService // Serviceklass implementerar Interface
    {

        private readonly IQRepo _questionRepo;
        private readonly IUserResRepo _resultRepo;

        public ResultService(IQRepo questionRepo, IUserResRepo resultRepo)
        {
            _questionRepo = questionRepo;
            _resultRepo = resultRepo;
        }

        public async Task<bool> SubmitAnswerAsync(string userId,int questionId,int selectedOptionId)
        {
            var question = await _questionRepo.GetQByIdAsync(questionId);

            var correctOption = question.AnswerOption; // Denna behöver korrigeras baserat på datamodeller Dummies är ej fullständiga!

            bool isCorrect = correctOption.Id == selectedOptionId; // Denna behöver korrigeras baserat på datamodeller Dummies är ej fullständiga!

            await _resultRepo.SaveAsync(new UserResult
            {
                UserId = userId, // Denna behöver korrigeras baserat på datamodeller Dummies är ej fullständiga!
                QuestionId = questionId, // Denna behöver korrigeras baserat på datamodeller Dummies är ej fullständiga!
                IsCorrect = isCorrect // Denna behöver korrigeras baserat på datamodeller Dummies är ej fullständiga!
            });

            return isCorrect;
        }
    }
}
