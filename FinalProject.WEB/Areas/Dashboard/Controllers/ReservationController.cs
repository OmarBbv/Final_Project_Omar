using Business.Concrete;
using Entities.Concrete.TableModels;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.WEB.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class ReservationController : Controller
    {
        ReservationManager _manager = new();

        public IActionResult Index()
        {
            var data = _manager.GetAll().Data;
            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Reservation reservation)
        {
            var data = _manager.Add(reservation);
            if (data.IsSuccess)
            {
                return RedirectToAction("Index");
            }
            return View(reservation);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var result = _manager.GetById(id).Data;
            return View(result);
        }

        [HttpPost]
        public IActionResult Edit(Reservation reservation)
        {
            var result = _manager.Update(reservation);
            if (result.IsSuccess)
            {
                return RedirectToAction("Index");
            }
            return View(reservation);
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
