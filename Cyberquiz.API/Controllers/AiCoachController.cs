using Microsoft.AspNetCore.Mvc;
using Cyberquiz.BLL.Interfaces;
using Cyberquiz.Shared.DTOs.AI_DTOs;

namespace Cyberquiz.API.Controllers
{
    [ApiController]
    [Route("api/aicoach")]
    public class AiCoachController : ControllerBase
    {
        private readonly IAiCoachService _aiCoachService;

        public AiCoachController(IAiCoachService aiCoachService)
        {
            _aiCoachService = aiCoachService;
        }

        [HttpGet("{userId}")]
        public async Task<ActionResult<AiFeedbackDto>> GetFeedback(string userId)
        {
            var result = await _aiCoachService.GetUserAnalysisAsync(userId);
            return Ok(result);
        }
    }
}
