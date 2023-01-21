using Microsoft.AspNetCore.Mvc;
using RevisaoProjetoNoticias.Domain.IServices;
using RevisaoProjetoNoticias.Web.Models;
using System.Diagnostics;

namespace RevisaoProjetoNoticias.Web.Controllers
{
    public class NewsController : Controller
    {
        private readonly ILogger<NewsController> _logger;
        private readonly INewsService _service;

        public NewsController(ILogger<NewsController> logger, INewsService service)
        {
            _logger = logger;
            _service = service;
        }

        public IActionResult Index()
        {
            return View(_service.FindAll());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}