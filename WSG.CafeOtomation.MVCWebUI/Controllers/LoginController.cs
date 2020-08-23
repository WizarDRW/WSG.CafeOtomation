using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
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
        public async Task<IActionResult> Login(string userName, string password)
        {
            var login = _authService.Login(new Entities.Dtos.UserForLoginDto { UserName = userName, Password = password });
            if (login.Success)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, login.Data.UserName)
                };

                var userIdentity = new ClaimsIdentity(claims, "Login");

                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", controllerName: "Home");
            }
            return BadRequest("Kullanici bilgileri yanlis!");
        }
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login");
        }
    }
}
