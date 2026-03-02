using Cyberquiz.BLL.Interfaces;
using Cyberquiz.DAL.Interface;
using Cyberquiz.DAL.Models;
using Cyberquiz.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cyberquiz.BLL.Services
{
    // Reglerar åtkomst
    // Använder ResultsService för att hämta information om användarens resultat
    public class ProgressService : IProgressService
    {
        private readonly IResultService _resultService;
        private readonly IQuestionRepository _questionRepo;
        private readonly IQuizRepository _quizRepository;

        public ProgressService(IResultService resultService, IQuestionRepository questionRepo, IQuizRepository quizRepository   )
        {
            _resultService = resultService;
            _questionRepo = questionRepo;
            _quizRepository = quizRepository;
        }

        // Metod för att avgöra om en subkategori är upplåst
        public async Task<bool> IsSubCategoryUnlockedAsync(string userId, int subCatId)
        {
            // Hämta frågor från underkategorin
            var questions = await _questionRepo.GetBySubCategoryAsync(subCatId);

            // Hämta användarens resultat för underkategorin
            var results = await _quizRepository.GetUserProgressAsync(userId, subCatId);

            // Om inga frågor: returnera false
            if (!questions.Any())
            {
                return false;
            }

            // Beräkna andel rätt svar
            double resultsScore = results.Count(res => res.IsCorrect) / (double)questions.Count();

            // Subkategorin är upplåst om användaren har minst 80% rätt
            return resultsScore >= 0.80;
        }
    }
}
