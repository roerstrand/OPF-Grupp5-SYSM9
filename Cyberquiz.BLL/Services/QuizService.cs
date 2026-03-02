using Cyberquiz.BLL.DummyFilesBLL;
using Cyberquiz.BLL.Interfaces;
using Cyberquiz.DAL.Repositories;
using Cyberquiz.Shared.DTOs;
using Cyberquiz.Shared.DTOs.Progress;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Mono.TextTemplating;
using System;
using System.Collections.Generic;
using System.Text;
using static Cyberquiz.BLL.DummyFilesBLL.DummyClassCollection;

namespace Cyberquiz.BLL.Services
{
    // Flödeslogik för att visa quiz för användaren
    // Starta quiz
    // Ta emot och validera svar
    // Kolla resultat
    // Säkerställa att quiz får startas
    public class QuizService : IQuizService
    {
        private readonly IQRepo _questionRepo;
        private readonly IProgressService _progressService;
        private readonly IResultService _resultService;

        public QuizService(IQRepo questionRepo, IProgressService progressService, IResultService resultService)
        {
            _questionRepo = questionRepo;
            _progressService = progressService;
            _resultService = resultService;
        }

        // Metod för att hämta frågor med svarsalternativ för en subkategori
        public async Task<List<QuestionDto>> GetQuestionsBySubCategoryAsync(int subCategoryId, string userId)
        {
            // Kolla om användaren har tillgång till subkategorin
            var isUnlocked = await _progressService.IsSubCategoryUnlockedAsync(userId, subCategoryId);
            if (!isUnlocked)
            {
                throw new UnauthorizedAccessException("Subkategorin är inte upplåst");
            }

            // Hämta frågor från repository
            var questions = await _questionRepo.GetBySubCategoryIdAsync(subCategoryId);

            // Slumpa ordning (valfritt)
            var shuffledQs = questions.OrderBy(q => Guid.NewGuid()).ToList();

            // Mappa till DTO (utan att visa rätt svar)
            return MapToQuestionDtos(shuffledQs);
        }

        private List<QuestionDto> MapToQuestionDtos(List<Question> questions)
        {
            // TODO: Implementera korrekt mappning när Question-modellen är klar
            return new List<QuestionDto>();
        }

        // Metod för att starta ett quiz
        public async Task<QuizDto> StartQuizAsync(int subCategoryId, string userId)
        {
            var questions = await GetQuestionsBySubCategoryAsync(subCategoryId, userId);

            return new QuizDto
            {
                SubCategoryId = subCategoryId,
                Questions = questions,
                //TotalQuestions = questions.Count
            };
        }

        // Metod för att skicka in ett svar
        public async Task<SubmitResponseDto> SubmitAnswerRequestAsync(string userId, int questionId, int selectedOptionId)
        {
            // Spara via ResultService
            var isCorrect = await _resultService.SubmitAnswerAsync(userId, questionId, selectedOptionId);

            return new SubmitResponseDto
            {
                IsCorrect = isCorrect
            };
        }
    }
}
