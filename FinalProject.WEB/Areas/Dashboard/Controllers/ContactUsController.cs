﻿using Business.Concrete;
using Entities.Concrete.TableModels;
using Entities.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.WEB.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class ContactUsController : Controller
    {
        ContactUsManager _contact = new();

        public IActionResult Index()
        {
            var data = _contact.GetAll().Data.Where(x => x.Deleted == 0).ToList();
            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ContactUsCreateDto contact)
        {
            var data =_contact.Add(contact);
            if(data.IsSuccess)
            {
                return RedirectToAction("Index");
            }

            return View(contact);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var result = _contact.GetById(id).Data;
            return View(result);
        }

        [HttpPost]
        public IActionResult Edit(ContactUsUpdateDto contact)
        {
            var result = _contact.Update(contact);
            if(result.IsSuccess)
            {
                return RedirectToAction("Index");
            }
            return View(contact);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var data = _contact.Delete(id);
            if (data.IsSuccess)
            {
                return RedirectToAction("Index");
            }

            return View(data);
        }
    }
}
