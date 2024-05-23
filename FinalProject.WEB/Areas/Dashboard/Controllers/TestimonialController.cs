using Business.Concrete;
using Entities.Concrete.TableModels;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.WEB.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class TestimonialController : Controller
    {

        TestimonialsManager _manager = new();

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
        public IActionResult Create(Testimonial p)
        {
            var data = _manager.Add(p);
            if (data.IsSuccess)
            {
                return RedirectToAction("Index");
            }
            return View(p);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var result = _manager.GetById(id).Data;
            return View(result);
        }

        [HttpPost]
        public IActionResult Edit(Testimonial p)
        {
            var result = _manager.Update(p);
            if (result.IsSuccess)
            {
                return RedirectToAction("Index");
            }
            return View(p);
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
