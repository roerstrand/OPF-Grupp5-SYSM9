using Cyberquiz.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Mono.TextTemplating;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cyberquiz.BLL.Services
{
    // Flödeslogik för att visa quiz för användaren
    // Starta quiz
    // Ta emot och validera svar
    // Sammanställa resultat
    // Säkerställa att quiz får startas
    public class QuizService : IQuizService // Serviceklass implementerar Interface
    {
        // Fält för progress-service
        private 
        // Konstruktor 
        public QuizService() 
        { 
        }
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
