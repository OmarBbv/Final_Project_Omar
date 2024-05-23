using Business.Concrete;
using Entities.Concrete.TableModels;
using Entities.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.WEB.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class ReservationController : Controller
    {
        ReservationManager _manager = new();

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
        public IActionResult Create(ReservationCreateDto dto)
        {
            var data = _manager.Add(dto);
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
        public IActionResult Edit(ReservationUpdateDto reservation)
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
