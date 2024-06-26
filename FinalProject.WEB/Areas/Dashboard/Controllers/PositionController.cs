﻿using Business.Concrete;
using Entities.Concrete.TableModels;
using Entities.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.WEB.Areas.Dashboard.Controllers
{
     [Area("Dashboard")]
    public class PositionController : Controller
    {
        PositionManager _position = new();

        public IActionResult Index()
        {
            var data = _position.GetAll().Data.Where(x => x.Deleted == 0).ToList();
            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(PositionCreateDto p)
        {
            var data = _position.Add(p);
            if (data.IsSuccess)
            {
                return RedirectToAction("Index");
            }
            return View(p);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var result = _position.GetById(id).Data;
            return View(result);
        }

        [HttpPost]
        public IActionResult Edit(PositionUpdateData p)
        {
            var result = _position.Update(p);
            if (result.IsSuccess)
            {
                return RedirectToAction("Index");
            }
            return View(p);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var data = _position.Delete(id);
            if (data.IsSuccess)
            {
                return RedirectToAction("Index");
            }
            return View(data);
        }
    }
}
