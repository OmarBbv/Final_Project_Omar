using Business.Concrete;
using Entities.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.WEB.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class TeamController : Controller
    {
        TeamManager _manager = new();
        PositionManager _position = new ();
        private readonly IWebHostEnvironment _env;

        public TeamController(IWebHostEnvironment webHostEnvironment)
        {
            _env = webHostEnvironment;
        }


        public IActionResult Index()
        {
            var data = _manager.GetAll().Data.Where(x => x.Deleted == 0).ToList();
            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var result = _position.GetAll().Data;
            ViewData["Position"] = _position.GetAll().Data;

            return View(result);
        }

        [HttpPost]
        public IActionResult Create(TeamCreateDto dto,IFormFile photoUrl)
        {
            var data = _manager.Add(dto,photoUrl,_env.WebRootPath);
            if (!data.IsSuccess)
            {
                return RedirectToAction("Index");
            }
            return View(dto);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var result = _manager.GetById(id).Data;
            return View(result);
        }

        [HttpPost]
        public IActionResult Edit(TeamUpdateDto dto,IFormFile photoUrl)
        {
            var result = _manager.Update(dto,photoUrl,_env.WebRootPath);
            if (result.IsSuccess)
            {
                return RedirectToAction("Index");
            }
            return View(dto);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var data = _manager.Delete(id);
            if (data.IsSuccess)
            {
                return RedirectToAction("Index");
            }
            return View(data);
        }
    }
}
