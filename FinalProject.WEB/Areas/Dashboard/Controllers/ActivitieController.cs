using Business.Concrete;
using Entities.Concrete.TableModels;
using Entities.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.WEB.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class ActivitieController : Controller
    {
        ActivitieManager _manager = new();
        AboutManager _aboutManager = new();

        public IActionResult Index()
        {
            var data=_manager.GetActiviteWithActivitieCategories().Data.Where(x=> x.Deleted ==0).ToList();
            //var data = _manager.GetAll().Data.Where(x => x.Deleted == 0).ToList();
            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var result = _aboutManager.GetAll().Data;
            ViewData["AboutCategory"] = result;
            return View();
        }
        [HttpPost]
        public IActionResult Create(ActivitieCreateDto dto)
        {
            var result =_manager.Add(dto);
            if(result.IsSuccess)
            {
                return  RedirectToAction("Index");
            }
            return View(dto);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewData["AboutCategory"] = _aboutManager.GetAll().Data;

            var data = _manager.GetById(id).Data;

            return View(data);
        }

        [HttpPost]
        public IActionResult Edit(ActivitieUpdateDto dto)
        {
            var result = _manager.Update(dto);
            if (result.IsSuccess)
                return RedirectToAction("Index");

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
