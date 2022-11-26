using Devs2Blu.ProjetosAula.PrimeiroProjetoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Devs2Blu.ProjetosAula.PrimeiroProjetoMVC.Controllers
{
    [Route("admin")]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            var user = new User
            {
                Id= 1,
                Name = "Guilherme Rafael Zimermann",
                Login = "GuilhermeRZ"
            };
            return View(user);
        }

        [Route("indicadores")]    
        [Route("numbers")]    
        public IActionResult Indicadores()
        {
            return View();
        }
        [Route("cards")]
        public PartialViewResult CardsResultados()
        {
            return PartialView();
        }
    }
}
