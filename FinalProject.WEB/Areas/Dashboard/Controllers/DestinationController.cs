using Business.Concrete;
using Entities.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.WEB.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class DestinationController : Controller
    {
        DestinationManager _destination = new();
        private readonly IWebHostEnvironment _env;

        public DestinationController(IWebHostEnvironment webHostEnvironment)
        {
            _env = webHostEnvironment;
        }

        public IActionResult Index()
        {
            var data = _destination.GetAll().Data.Where(x => x.Deleted == 0).ToList();
            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(DestinationCreateDto dto, IFormFile photoUrl)
        {
            var data = _destination.Add(dto,photoUrl,_env.WebRootPath);
            if (data.IsSuccess)
            {
                return RedirectToAction("Index");
            }
            return View(data);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var result = _destination.GetById(id).Data;
            return View(result);
        }

        [HttpPost]
        public IActionResult Edit(DestinationUpdateDto dto, IFormFile photoUrl)
        {
            var result = _destination.Update(dto, photoUrl, _env.WebRootPath);
            if(result.IsSuccess)
            {
                return RedirectToAction("Index");
            }

            return View(dto);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var data = _destination.Delete(id);
            if(data.IsSuccess)
            {
                return RedirectToAction("Index");
            }

            return View(data);
        }
    }
}
