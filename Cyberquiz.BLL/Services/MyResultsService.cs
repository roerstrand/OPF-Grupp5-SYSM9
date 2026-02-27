using Cyberquiz.BLL.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Text;
using static Microsoft.CodeAnalysis.CSharp.SyntaxTokenParser;

namespace Cyberquiz.BLL.Services
{
    // Hanterar användarnas framgång
    // Spara resultat
    // Hämta senaste resultat
    // Hämta historik
    // Räkna genomsnitt
    // Räkna procent
    public class MyResultsService : IMyResultsService // Serviceklass implementerar Interface
    {
        private int correctAnswers;
        private int totalQuestions;
        private double userScore;
        
        // Konstruktor 
        public MyResultsService() 
        {
            // Här kan du initiera eventuella resurser eller databasanslutningar
        }

        // Metoder

        new UserResult
{
            CorrectAnswers = 8,
    TotalQuestions = 10
}
    }
}
