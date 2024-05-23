using Business.Concrete;
using Entities.Concrete.TableModels;
using Entities.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.WEB.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class PackageController : Controller
    {

        PackageManager _package = new();
        private readonly IWebHostEnvironment _env;


        public PackageController(IWebHostEnvironment webHostEnvironment)
        {
            _env = webHostEnvironment;
        }

        public IActionResult Index()
        {
            var data = _package.GetAll().Data.Where(x => x.Deleted == 0).ToList();
            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(PackageCreateDto dto, IFormFile photoUrl)
        {
            var data = _package.Add(dto, photoUrl, _env.WebRootPath);
            if (data.IsSuccess)
            {
                return RedirectToAction("Index");
            }
            return View(dto);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var result = _package.GetById(id).Data;
            return View(result);
        }

        [HttpPost]
        public IActionResult Edit(PackageUpdateDto dto,IFormFile photoUrl)
        {
            var result = _package.Update(dto,photoUrl,_env.WebRootPath);
            if (result.IsSuccess)
            {
                return RedirectToAction("Index");
            }
            return View(dto);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var data = _package.Delete(id);
            if (data.IsSuccess)
            {
                return RedirectToAction("Index");
            }
            return View(data);
        }
    }
}
