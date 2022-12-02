using Microsoft.AspNetCore.Mvc;

namespace Devs2Blu.ProjetosAula.DndInfoWebsite.Controllers
{
    public class DndController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AbilityScores()
        {
            return View();
        }
    }
}
