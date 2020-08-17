using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WSG.CafeOtomation.Business.Abstract;

namespace WSG.CafeOtomation.MVCWebUI.Controllers
{
    public class LoginController : Controller
    {
        private IAuthService _authService;
        public LoginController(IAuthService authService)
        {
            _authService = authService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string userName, string password)
        {
            bool islogin = _authService.Login(new Entities.Dtos.UserForLoginDto { UserName = userName, Password = password }).Success;
            if (islogin)
            {
                return RedirectToAction("Index", controllerName: "Home");
            }
            return BadRequest("Kullanici bilgileri yanlis!");
        }
    }
}
