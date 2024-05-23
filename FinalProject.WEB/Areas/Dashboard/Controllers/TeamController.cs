using Business.Concrete;
using Entities.Concrete.TableModels;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.WEB.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class TeamController : Controller
    {
        TeamManager _manager = new();
        PositionManager _position = new ();

        public IActionResult Index()
        {
            var data = _manager.GetAll().Data.Where(x => x.Deleted == 0).ToList();
            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var result = _position.GetAll().Data;
            ViewData["Position"] = _position.GetAll().Data;;

            return View(result);
        }

        [HttpPost]
        public IActionResult Create(Team e)
        {
            var data = _manager.Add(e);
            if (data.IsSuccess)
            {
                return RedirectToAction("Index");
            }
            return View(e);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var result = _manager.GetById(id).Data;
            return View(result);
        }

        [HttpPost]
        public IActionResult Edit(Team e)
        {
            var result = _manager.Update(e);
            if (result.IsSuccess)
            {
                return RedirectToAction("Index");
            }
            return View(e);
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
