using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RevisaoProjetoNoticias.Application.Service.SQLServerServices;
using RevisaoProjetoNoticias.Domain.IServices;
using RevisaoProjetoNoticias.Web.Models;
using System.Diagnostics;

namespace RevisaoProjetoNoticias.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ILogger<CategoryController> _logger;
        private readonly ICategoryService _service;

        public CategoryController(ILogger<CategoryController> logger, ICategoryService service)
        {
            _logger = logger;
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            return View(_service.FindAll());
        }

        public IActionResult Add()
        {
            return View();
        }

    }
}