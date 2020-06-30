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
    public class OrdersController : ControllerBase
    {
        private IOrderService _orderService;
        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _orderService.GetAll();
            return Ok(result.Data);
        }
        [HttpGet("getbydesk")]
        public IActionResult GetByDesk(int id)
        {
            var result = _orderService.GetByDesk(id);
            return Ok(result.Data);
        }
        [HttpGet("getbyclose")]
        public IActionResult GetByClose(bool close)
        {
            var result = _orderService.GetByClose(close);
            return Ok(result.Data);
        }
        [HttpPost("add")]
        public IActionResult Add(Order order)
        {
            var result = _orderService.Add(order);
            return Ok(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Order order)
        {
            var result = _orderService.Update(order);
            return Ok(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Order order)
        {
            var result = _orderService.Delete(order);
            return Ok(result);
        }
    }
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailsController : ControllerBase
    {
        private IOrderDetailService _orderDetailService;
        public OrderDetailsController(IOrderDetailService orderDetailService)
        {
            _orderDetailService = orderDetailService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _orderDetailService.GetAll();
            return Ok(result.Data);
        }
        [HttpGet("getbyorderno")]
        public IActionResult GetByOrderNo(int id)
        {
            var result = _orderDetailService.GetByOrderNo(id);
            return Ok(result.Data);
        }
        [HttpPost("add")]
        public IActionResult Add(OrderDetail orderDetail)
        {
            var result = _orderDetailService.Add(orderDetail);
            return Ok(result);
        }
        [HttpPost("update")]
        public IActionResult Update(OrderDetail orderDetail)
        {
            var result = _orderDetailService.Update(orderDetail);
            return Ok(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(OrderDetail orderDetail)
        {
            var result = _orderDetailService.Delete(orderDetail);
            return Ok(result);
        }
    }
}
