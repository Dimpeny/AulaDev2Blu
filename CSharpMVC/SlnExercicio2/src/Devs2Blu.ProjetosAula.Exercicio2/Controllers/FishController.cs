using Devs2Blu.ProjetosAula.Exercicio2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Devs2Blu.ProjetosAula.Exercicio2.Controllers
{
    [Route("Fish")]
    public class FishController : Controller
    {
        private readonly ILogger<FishController> _logger;
        private readonly ServiceAPIFish service;
        public FishController(ILogger<FishController> logger)
        {
            _logger = logger;
            service = new ServiceAPIFish();
        }
        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("loadfish")]
        public async Task<PartialViewResult> LoadListFish()
        {
            _logger.LogInformation("Loading fish list");
            var result = await service.GetListFish();
            var listFish = result.ToList();
            return PartialView(listFish);
        }
    }
}
