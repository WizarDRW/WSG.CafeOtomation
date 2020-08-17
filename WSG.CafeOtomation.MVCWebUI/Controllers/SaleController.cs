using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WSG.CafeOtomation.Business.Abstract;

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
        public IActionResult Index(DateTime startDate, DateTime endDate)
        {
            if (startDate != null && endDate != null)
            {
                var data = _orderService.GetAll(x => x.CreateDate.Date >= startDate.Date && x.CreateDate.Date <= endDate.Date).Data;
                ViewBag.Payments = _orderPaymentService.GetAll(x => x.CreateDate.Date >= startDate.Date && x.CreateDate.Date <= endDate.Date).Data.GroupBy(x => x.PayTypeID).Select(x => new { Total = x.Sum(c=>c.Value), x.Key }).ToList();
                foreach (var item in data)
                {
                    _orderDetailsCount += _orderDetailService.GetByOrderNo(item.ID).Data.Count;
                    var dataPayment = _orderPaymentService.GetAll(x => x.OrderID == item.ID).Data;
                    if (dataPayment.Count > 0)
                    {
                        _cash += dataPayment.Where(x => x.PayTypeID == 1).Sum(x => x.Value);
                        _credit += dataPayment.Where(x => x.PayTypeID == 2).Sum(x => x.Value);
                        _food += dataPayment.Where(x => x.PayTypeID == 3).Sum(x => x.Value);
                    }
                }
                ViewBag.OrderDetailCount = _orderDetailsCount;
                ViewBag.Cash = _cash;
                ViewBag.BankCredit = _credit;
                ViewBag.FoodCart = _food;
                return View(data);
            }
            return View(_orderService.GetAll().Data);
        }
    }
}
