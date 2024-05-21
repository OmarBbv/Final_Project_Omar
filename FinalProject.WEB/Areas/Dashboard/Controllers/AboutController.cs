using Business.Concrete;
using Entities.Concrete.TableModels;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.WEB.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class AboutController : Controller
    {
        AboutManager _manager = new();

        public IActionResult Index()
        {
            var data=_manager.GetAll().Data;
            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return  View();
        }

        [HttpPost]
        public IActionResult Create(About about)
        {
            var data=_manager.Add(about);
            if(data.IsSuccess)
            {
                return RedirectToAction("Index");
            }
            return View(about);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var result=_manager.GetById(id).Data;
            return View(result);
        }

        [HttpPost]
        public IActionResult Edit(About about)
        {
            var result=_manager.Update(about);
            if(result.IsSuccess)
            {
                return RedirectToAction("Index");
            }
            return View(about);
        }
        
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var data = _manager.Delete(id);
            if( data.IsSuccess)
            {
                return RedirectToAction("Index");
            }
            return View(data);
        }
    }
   
}
