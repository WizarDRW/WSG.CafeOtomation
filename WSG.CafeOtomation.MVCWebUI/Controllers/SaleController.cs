using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WSG.CafeOtomation.Business.Abstract;
using WSG.CafeOtomation.Entities.Concrete;
using WSG.CafeOtomation.Entities.Dtos;

namespace WSG.CafeOtomation.MVCWebUI.Controllers
{
    public class SaleController : Controller
    {
        private IOrderService _orderService;
        private IOrderPaymentService _orderPaymentService;
        private IOrderDetailService _orderDetailService;
        private decimal _cash = 0, _credit = 0, _food = 0, _orderDetailsCount = 0;
        public SaleController(IOrderService orderService, IOrderPaymentService orderPaymentService, IOrderDetailService orderDetailService)
        {
            _orderService = orderService;
            _orderPaymentService = orderPaymentService;
            _orderDetailService = orderDetailService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult OrderTotal(DateTime startDate, DateTime endDate)
        {
            if (startDate != null && endDate != null)
            {
                var data = _orderDetailService.GetAll(x => x.CreateDate.Date >= startDate.Date && x.CreateDate.Date <= endDate.Date).Data;
                var datapayments = _orderPaymentService.GetAll(x => x.CreateDate.Date >= startDate.Date && x.CreateDate.Date <= endDate.Date).Data.GroupBy(x => x.PayType).Select(x => new OrderPaymentDto { PayType = x.Key, TotalPrice = x.Sum(y => y.TotalPrice) }).ToList();
                ViewBag.Payments = datapayments;
                ViewBag.Payed = datapayments.Sum(x => x.TotalPrice);
                return PartialView(data);
            }
            return PartialView();
        }
    }
}
