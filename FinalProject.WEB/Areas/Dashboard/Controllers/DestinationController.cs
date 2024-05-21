using Business.Concrete;
using Entities.Concrete.TableModels;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.WEB.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class DestinationController : Controller
    {
        DestinationManager _destination = new();

        public IActionResult Index()
        {
            var data = _destination.GetAll().Data;
            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Destination destination)
        {
            var data = _destination.Add(destination);
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
        public IActionResult Edit(Destination destination)
        {
            var result = _destination.Update(destination);
            if(result.IsSuccess)
            {
                return RedirectToAction("Index");
            }

            return View(destination);
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
