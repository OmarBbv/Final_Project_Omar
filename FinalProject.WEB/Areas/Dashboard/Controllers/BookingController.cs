using Business.Concrete;
using Entities.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.WEB.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class BookingController : Controller
    {
        BookingManager _booking = new();
        private readonly IWebHostEnvironment _env;

        public BookingController(IWebHostEnvironment webHostEnvironment)
        {
            _env = webHostEnvironment;
        }

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
        public IActionResult Create(BookingCreateDto dto,IFormFile photoUrl)
        {
            
            var data = _booking.Add(dto,photoUrl,_env.WebRootPath);
            if (data.IsSuccess)
            {
                return RedirectToAction("Index");
            }
            return View(dto);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var result = _booking.GetById(id).Data;
            return View(result);
        }

        [HttpPost]
        public IActionResult Edit(BookingUpdateDto dto,IFormFile photoUrl)
        {
            var result = _booking.Update(dto, photoUrl, _env.WebRootPath);
            if (result.IsSuccess)
            {
                return RedirectToAction("Index");
            }
            return View(dto);
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
