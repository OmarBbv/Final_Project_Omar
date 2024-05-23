using Business.Concrete;
using Entities.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.WEB.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class AboutController : Controller
    {
        AboutManager _manager = new();
        private readonly IWebHostEnvironment _env;

        public AboutController(IWebHostEnvironment webHostEnvironment)
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
            return View();
        }

        [HttpPost]
        public IActionResult Create(AboutCreateDto dto,IFormFile photoUrl)
        {
            var data = _manager.Add(dto,photoUrl,_env.WebRootPath);
            if (data.IsSuccess)
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
        public IActionResult Edit(AboutUpdateDto dto,IFormFile photoUrl)
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
