using Business.Concrete;
using Entities.Concrete.TableModels;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.WEB.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class PackageController : Controller
    {

        PackageManager _package = new();

        public IActionResult Index()
        {
            var data = _package.GetAll().Data;
            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Package p)
        {
            var data = _package.Add(p);
            if (data.IsSuccess)
            {
                return RedirectToAction("Index");
            }
            return View(p);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var result = _package.GetById(id).Data;
            return View(result);
        }

        [HttpPost]
        public IActionResult Edit(Package p)
        {
            var result = _package.Update(p);
            if (result.IsSuccess)
            {
                return RedirectToAction("Index");
            }
            return View(p);
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
