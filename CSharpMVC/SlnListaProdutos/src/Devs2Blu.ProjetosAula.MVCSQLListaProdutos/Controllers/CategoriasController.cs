using Devs2Blu.ProjetosAula.MVCSQLListaProdutos.Models;
using Devs2Blu.ProjetosAula.MVCSQLListaProdutos.Models.Entities;
using Devs2Blu.ProjetosAula.MVCSQLListaProdutos.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Devs2Blu.ProjetosAula.MVCSQLListaProdutos.Controllers
{
    public class CategoriasController : Controller
    {
        private readonly ICategoriaService _service;

        public CategoriasController(ICategoriaService service)
        {
            _service = service;
        }

        // GET: CategoriasController
        public async Task<ActionResult> Index()
        {
            var listaCategorias = await _service.GetAllCategorias();
            return View(listaCategorias);
        }

        // GET: CategoriasController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CategoriasController/Create
        public ActionResult Create()
        {
            

            return View();
            

        }

        // POST: CategoriasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult>  Create([Bind("Id,Nome")] Categoria categoria)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    await _service.Save(categoria);
                    return RedirectToAction(nameof(Index));
                }

                return View(categoria);
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoriasController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CategoriasController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoriasController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CategoriasController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
