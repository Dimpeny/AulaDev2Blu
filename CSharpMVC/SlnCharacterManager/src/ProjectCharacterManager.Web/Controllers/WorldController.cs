using Microsoft.AspNetCore.Mvc;
using ProjectCharacterManager.Domain.DTO;
using ProjectCharacterManager.Domain.IServices;

namespace ProjectCharacterManager.Web.Controllers
{
    public class WorldController : Controller
    {
        private readonly ILogger<WorldController> _logger;
        private readonly IWorldService _service;

        public WorldController(ILogger<WorldController> logger, IWorldService service)
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
        public async Task<IActionResult> Create([Bind("id,name,description")] WorldDTO world)
        {
            if (ModelState.IsValid)
            {
                if (await _service.Save(world) > 0)
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(world);
        }

        public async Task<IActionResult> Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var world = await _service.FindById(id);
            return View(world);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int? id, [Bind("id, name, description")] WorldDTO world)
        {
            if (!(world.id == id))
            {
                return NotFound();

            }
            if (ModelState.IsValid)
            {
                if (await _service.Save(world) > 0)
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(world);
        }

        public async Task<IActionResult> Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var world = await _service.FindById(id);
            return View(world);
        }

        [HttpPost]
        public async Task<JsonResult> Delete(int? id)
        {
            var retDel = new ReturnJsonDel
            {
                status = "Success",
                code = "200"
            };
            if (await _service.Delete(id ?? 0) <= 0)
            {
                retDel = new ReturnJsonDel
                {
                    status = "Error",
                    code = "400"
                };
            }
            return Json(retDel);
        }

    }
}

