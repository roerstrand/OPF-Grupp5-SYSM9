using Microsoft.AspNetCore.Mvc;

namespace Cyberquiz.API.Controllers
{
    public class AiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
