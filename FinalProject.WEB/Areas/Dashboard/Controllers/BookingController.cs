using Business.Concrete;
using Entities.Concrete.TableModels;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.WEB.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class BookingController : Controller
    {
        BookingManager _booking = new();

        public IActionResult Index()
        {
            var data = _booking.GetAll().Data.Where(x=> x.Deleted == 0).ToList();
            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Booking booking)
        {
            var data = _booking.Add(booking);
            if (data.IsSuccess)
            {
                return RedirectToAction("Index");
            }
            return View(booking);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var result = _booking.GetById(id).Data;
            return View(result);
        }

        [HttpPost]
        public IActionResult Edit(Booking booking)
        {
            var result = _booking.Update(booking);
            if (result.IsSuccess)
            {
                return RedirectToAction("Index");
            }
            return View(booking);
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var data = _booking.Delete(id);
            if (data.IsSuccess)
            {
                return RedirectToAction("Index");
            }
            return View(data);
        }
    }
}
