using Microsoft.AspNetCore.Mvc;

namespace Testemvc.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Indicadores()
        {
            return View();
        }
    }
}
