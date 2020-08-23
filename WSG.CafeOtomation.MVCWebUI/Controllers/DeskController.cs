using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WSG.CafeOtomation.Business.Abstract;
using WSG.CafeOtomation.Entities.Concrete;

namespace WSG.CafeOtomation.MVCWebUI.Controllers
{
    [Authorize]
    public class DeskController : Controller
    {
        private IDeskService _deskService;
        public DeskController(IDeskService deskService)
        {
            _deskService = deskService;
        }
        public IActionResult Index()
        {
            var data = _deskService.GetAll().Data;
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Desk desk)
        {
            desk.UniqueIdentifier = Guid.NewGuid().ToString();
            var result = _deskService.Add(desk);
            if (result.Success)
            {
                return Redirect("Index");
            }
            return BadRequest("Eklenemedi!");
        }
        
        public IActionResult Edit(string id)
        {
            var data = _deskService.GetByUnique(id).Data;
            return View(data);
        }

        [HttpPost]
        public IActionResult Edit(Desk desk)
        {
            var result = _deskService.Update(desk);
            if (result.Success)
            {
                return Redirect("Index");
            }
            return BadRequest("Güncellenemedi!");
        }

        public IActionResult Delete(string id)
        {
            var data = _deskService.GetByUnique(id).Data;
            return View(data);
        }
        [HttpPost]
        public IActionResult Delete(Desk desk)
        {
            var result = _deskService.Delete(desk);
            if (result.Success)
            {
                return Redirect("Index");
            }
            return BadRequest("Silinemedi!");
        }
    }
}
