using Cyberquiz.Shared.DTOs;

namespace Cyberquiz.UI.Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<CategoryDto>?> GetCategoriesAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<CategoryDto>>("api/categories");
        }

        public async Task<CategoryDto?> GetCategoryByIdAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<CategoryDto>($"api/categories/{id}");
        }

        // === SubCategories ===
        public async Task<List<SubCategoryDto>?> GetSubCategoriesByCategoryIdAsync(int categoryId)
        {
            return await _httpClient.GetFromJsonAsync<List<SubCategoryDto>>($"api/categories/{categoryId}/subcategories");
        }

        public async Task<SubCategoryDto?> GetSubCategoryByIdAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<SubCategoryDto>($"api/subcategories/{id}");
        }

        public async Task<List<QuestionDto>?> GetQuestionsBySubCategoryIdAsync(int subCategoryId)
        {
            return await _httpClient.GetFromJsonAsync<List<QuestionDto>>($"api/quiz/subcategory/{subCategoryId}");
        }

        //public async Task<QuizResultDto?> SubmitQuizAnswerAsync(int questionId, int answerId)
        //{
        //    var response = await _httpClient.PostAsJsonAsync($"api/quiz/submit", new { QuestionId = questionId, AnswerId = answerId });
        //    return await response.Content.ReadFromJsonAsync<QuizResultDto>();
        //}

        // === Progress ===
        public async Task<bool> IsSubCategoryUnlockedAsync(int subCategoryId)
        {
            return await _httpClient.GetFromJsonAsync<bool>($"api/progress/unlocked/{subCategoryId}");
        }

        //public async Task<ProgressDto?> GetUserProgressAsync()
        //{
        //    return await _httpClient.GetFromJsonAsync<ProgressDto>("api/progress");
        //}

        // === User Results ===
        public async Task<List<UserResultDto>?> GetUserResultsAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<UserResultDto>>("api/results");
        }

        public async Task<UserResultDto?> GetResultBySubCategoryAsync(int subCategoryId)
        {
            return await _httpClient.GetFromJsonAsync<UserResultDto>($"api/results/subcategory/{subCategoryId}");
        }
    }
}
