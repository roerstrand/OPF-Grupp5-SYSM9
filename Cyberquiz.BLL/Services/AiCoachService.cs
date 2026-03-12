using Cyberquiz.BLL.Interfaces;
using Cyberquiz.Shared.DTOs.AI_DTOs;
using Microsoft.Extensions.Logging;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cyberquiz.BLL.Services
{
    public class AiCoachService
    {
        // Hämta användarens resultat
        // Sammanställa statistik
        // Skicka prompt till AI
        // Returnera AI-feedback

        private readonly IProgressService _progressService;
        private readonly IOpenAiClient _openAiClient;
        public AiCoachService(IProgressService progressService, IOpenAiClient openAiClient)
        {
            _progressService = progressService;
            _openAiClient = openAiClient;
        }

        // Metod för analys
        public async Task<AiFeedbackDto> GetUserAnalysisAsync(string userName)
        {
            // Hämtar användarens resultat
            var history = await _progressService.GetAllByUserAsync(userName);
            // Bygger en sammanfattning
            var summary = BuildSummary(history);
            // och skickar sammanfattning till OpenAI för att få feedback
            var aiResponse = await _openAiClient.GetFeedback(summary);
            return new AiFeedbackDto
            {
                Feedback = aiResponse
            };
        }
    }
}
