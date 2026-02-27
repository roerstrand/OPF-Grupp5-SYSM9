using Microsoft.AspNetCore.Mvc;

namespace Cyberquiz.API.Controllers
{
    [ApiController]
    [Route("api/quiz")]
    public class QuizController : Controller
    {
        //private readonly IQuizService _quizService;

        //public QuizController(IQuizService quizService)
        //{
        //    _quizService = quizService;
        //}
        
        //[HttpGet("/api/quizzes")]
        //public async Task<ActionResult<List<QuizDto>>> GetQuizzes()
        //{
        //    var quizzes = await _quizService.GetAllAsync();
        //    return Ok(quizzes);
        //}
    }
}
