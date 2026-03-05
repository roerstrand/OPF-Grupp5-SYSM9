using Cyberquiz.BLL.Interfaces;
using Cyberquiz.DAL.Models;
using Cyberquiz.DAL.Interface;
using Cyberquiz.Shared.DTOs;
using Cyberquiz.Shared.DTOs.Progress;

namespace Cyberquiz.BLL.Services
{
    public class QuestionService : IQuestionService
    {
        private readonly IQuestionRepository _questionRepo;
        public QuestionService(IQuestionRepository questionRepo)
        {
            _questionRepo = questionRepo;
        }
        public async Task<QuestionDto?> GetByIdAsync(int id)
        {
            var question = await _questionRepo.GetByIdAsync(id);
            return question == null ? null : MapToQuestionDto(question);
        }

        public async Task<IEnumerable<QuestionDto>> GetBySubCategoryAsync(int subCategoryId)
        {
            var questions = await _questionRepo.GetBySubCategoryAsync(subCategoryId);
            return questions.Select(MapToQuestionDto);
        }

        // Metod för ENDPOINT "subcategory/{subCategoryId:int}/next"
        // Metoden hämtar nästa fråga för en användare inom en specifik subkategori, baserat på användarens tidigare svar och framsteg
        public async Task<QuestionDto?> GetNextQuestionAsync(string userName, int subCategoryId)
        {
            var question = await _questionRepo.GetNextQuestionAsync(userName, subCategoryId);
            return question == null ? null : MapToQuestionDto(question);
        }

        // Mapping-metod från Model till Dto
        private QuestionDto MapToQuestionDto(QuestionModel model)
        {
            return new QuestionDto
            {
                Id = model.Id,
                Question = model.Question,
                AnswerOptions = model.QuestionAnswerOptions?
                    .Select(qao => new AnswerOptionDto
                    {
                        Id = qao.AnswerOption.Id,
                        Answer = qao.AnswerOption.Answer
                    })
                    .ToList() ?? new List<AnswerOptionDto>()
            };
        }
    }
}
