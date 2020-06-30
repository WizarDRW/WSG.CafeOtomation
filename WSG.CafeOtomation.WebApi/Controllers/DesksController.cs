using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WSG.CafeOtomation.Business.Abstract;
using WSG.CafeOtomation.Entities.Concrete;

namespace WSG.CafeOtomation.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DesksController : ControllerBase
    {
        private IDeskService _deskService;
        public DesksController(IDeskService deskService)
        {
            _deskService = deskService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _deskService.GetAll();
            return Ok(result.Data);
        }
        [HttpGet("getbyno")]
        public IActionResult GetByNo(string no)
        {
            var result = _deskService.GetByNo(no);
            return Ok(result.Data);
        }
        [HttpGet("getbyunique")]
        public IActionResult GetByUnique(string no)
        {
            var result = _deskService.GetByUnique(no);
            return Ok(result.Data);
        }
        [HttpPost("add")]
        public IActionResult Add(Desk desk)
        {
            var result = _deskService.Add(desk);
            return Ok(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Desk desk)
        {
            var result = _deskService.Update(desk);
            return Ok(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Desk desk)
        {
            var result = _deskService.Delete(desk);
            return Ok(result);
        }
    }
}
