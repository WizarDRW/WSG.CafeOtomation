using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WSG.CafeOtomation.Business.Abstract;

namespace WSG.CafeOtomation.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _userService.GetAll();
            if (result.Success)
                return Ok(result.Data);
            return BadRequest(result.Message);
        }
    }
    [Route("api/[controller]")]
    [ApiController]
    public class TitlesController : ControllerBase
    {
        private ITitleService _titleService;
        public TitlesController(ITitleService titleService)
        {
            _titleService = titleService;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _titleService.GetAll();
            if (result.Success)
                return Ok(result.Data);
            return BadRequest(result.Message);
        }
    }
}
