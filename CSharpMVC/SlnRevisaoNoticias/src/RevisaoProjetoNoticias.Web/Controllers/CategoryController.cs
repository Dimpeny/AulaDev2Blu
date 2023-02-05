using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RevisaoProjetoNoticias.Application.Service.SQLServerServices;
using RevisaoProjetoNoticias.Domain.DTO;
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

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("id,name")]CategoryDTO category)
        {
            if (ModelState.IsValid)
            {
                if (await _service.Save(category)>0)
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(category);
        }

        public async Task<IActionResult> Edit(int id)
        {
            if(id == null)
            {
                return NotFound();
            } 
            var category = await _service.FindById(id);
            return View(category);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int? id, [Bind("id, name")] CategoryDTO category)
        {
            if(!(category.id == id))
            {
                return NotFound();

            }
            if (ModelState.IsValid)
            {
                if (await _service.Save(category) > 0)
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(category);
        }

        public async Task<IActionResult> Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var category = await _service.FindById(id);
            return View(category);
        }

        [HttpPost]
        public async Task<JsonResult> Delete(int? id)
        {
            var returnDelete = new ReturnJsonDel
            {
                status = "sucess",
                code = "200"
            };
            if(await _service.Delete(id ?? 0) <=0)
            {
                returnDelete = new ReturnJsonDel
                {
                    status = "Error",
                    code = "400"
                };
            }
            return Json(returnDelete);
        }

        
    }

    public class ReturnJsonDel
    {
        public string status { get; set; }
        public string code { get; set; }
    }
}