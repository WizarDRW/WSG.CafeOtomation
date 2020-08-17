using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WizardSoftwareGroupsFramework.Core.Entities.Concrete;
using WSG.CafeOtomation.Business.Abstract;
using WSG.CafeOtomation.Entities.Dtos;

namespace WSG.CafeOtomation.MVCWebUI.Controllers
{
    public class UserController : Controller
    {
        private IUserService _userService;
        private IAuthService _authService;
        public UserController(IUserService userService, IAuthService authService)
        {
            _authService = authService;
            _userService = userService;
        }
        public IActionResult Index()
        {
            return View(_userService.GetAll().Data);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(UserForRegisterDto userForRegisterDto)
        {
            var result = _authService.Register(userForRegisterDto);
            if (result.Success)
            {
                return Redirect("Index");
            }
            return BadRequest();
        }
        public IActionResult Edit(int id)
        {
            return View(_userService.GetByID(id).Data);
        }
    }
}
