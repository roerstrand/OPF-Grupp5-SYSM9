using Cyberquiz.BLL.DummyFilesBLL;
using Cyberquiz.BLL.Interfaces;
using Cyberquiz.DAL.Repositories;
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
    // Sammanställa resultat
    // Säkerställa att quiz får startas
    public class QuizService : IQuizService // Serviceklass implementerar Interface
    {

        // Fält
        private readonly IQRepo _questionRepo;

        // Konstruktor
        public QuizService(IQRepo questionRepo)
        {
            _questionRepo = questionRepo;
        }
        // Metod för att hämta frågor baserat på underkategori

        public async Task<List<Question>> GetQuestionsAsync(int subCategoryId)
        {
            return await _questionRepo.GetBySubCategoryIdAsync(subCategoryId);
        }

        // KOMMANDE METODER

        // StartQuizAsync
        // Kolla via ProgressService om upplåst
        // Hämta frågor
        // Slumpa ordning(valfritt men bra)
        // Mappa till QuizDto(utan IsCorrect)

        // SubmitAnswerAsync
        // Kolla att frågan tillhör rätt subkategori
        // Kolla att alternativet tillhör frågan
        // Kolla om svar är rätt
        // Returnera feedback
    }
}
