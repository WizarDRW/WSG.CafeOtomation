using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Ocsp;
using WSG.CafeOtomation.Business.Abstract;
using WSG.CafeOtomation.Entities.Concrete;
using WSG.CafeOtomation.Entities.Dtos;

namespace WSG.CafeOtomation.MVCWebUI.Controllers
{
    public class CustomerDeskController : Controller
    {
        private IProductService _productService;
        private IProductCategoryService _productCategoryService;
        private IProductImageService _productImageService;
        private IOrderService _orderService;
        private IOrderDetailService _orderDetailService;
        private IDeskService _deskService;
        public CustomerDeskController(IProductService productService,
            IProductCategoryService productCategoryService,
            IProductImageService productImageService,
            IOrderService orderService,
            IOrderDetailService orderDetailService,
            IDeskService deskService)
        {
            _productService = productService;
            _productCategoryService = productCategoryService;
            _productImageService = productImageService;
            _orderService = orderService;
            _orderDetailService = orderDetailService;
            _deskService = deskService;
        }
        public IActionResult Index(string deskUniqueID)
        {
            ViewBag.DeskUniqueID = deskUniqueID;
            return View();
        }
        public IActionResult MenuCategoryIndex(string deskUniqueID)
        {
            ViewBag.DeskUniqueID = deskUniqueID;
            return View(_productCategoryService.GetAll().Data.OrderBy(x => x.Order));
        }
        public IActionResult MenuIndex(string categoryName, int categoryID, string deskUniqueID)
        {
            ViewBag.Title = categoryName;
            ViewBag.DeskUniqueID = deskUniqueID;
            return View(_productService.GetByCategory(categoryID).Data);
        }
        public IActionResult OrderStatusIndex(string deskUniqueID)
        {
            ViewBag.DeskUniqueID = deskUniqueID;
            var desk = _deskService.GetByUnique(deskUniqueID);
            var order = _orderService.GetByDesk(desk.Data.ID).Data.Where(x => !x.IsClose);
            var data = _orderDetailService.GetAll(x => x.OrderID == order.SingleOrDefault().ID).Data;
            return View(data);
        }

        [HttpPost]
        public IActionResult CreateOrder(CustomerOrderCreateDto customerOrderCreateDto)
        {
            var desk = _deskService.GetByUnique(customerOrderCreateDto.DeskUniqueId).Data;
            var product = _productService.GetByID(customerOrderCreateDto.ProductID).Data;
            var order = _orderService.GetByDesk(desk.ID).Data.Where(x => !x.IsClose);
            if (order.Count() < 1)
            {
                var orderCreate = new Order
                {
                    TotalPrice = customerOrderCreateDto.Amount * product.UnitPrice,
                    DeskID = desk.ID,
                    CreateDate = DateTime.Now
                };
                var result = _orderService.Add(orderCreate);
                if (result.Success)
                {
                    result = _orderDetailService.Add(new OrderDetail
                    {
                        Amount = customerOrderCreateDto.Amount,
                        EOrderStatus = OrderStatus.Waiting,
                        OrderID = orderCreate.ID,
                        ProductID = product.ID,
                        TotalPrice = customerOrderCreateDto.Amount * product.UnitPrice,
                        CreateDate = DateTime.Now
                    });
                }
                return Json(result);
            }
            else
            {
                var result = _orderDetailService.Add(new OrderDetail
                {
                    Amount = customerOrderCreateDto.Amount,
                    EOrderStatus = OrderStatus.Waiting,
                    OrderID = order.SingleOrDefault().ID,
                    ProductID = product.ID,
                    TotalPrice = customerOrderCreateDto.Amount * product.UnitPrice,
                    CreateDate = DateTime.Now
                });
                return Json(result);
            }
        }
        [HttpDelete]
        public JsonResult Delete(int id)
        {
            var orderDetail = _orderDetailService.GetBy(x => x.ID == id).Data;
            if (orderDetail.EOrderStatus == OrderStatus.Waiting)
            {
                if (_orderDetailService.GetAll(x => x.OrderID == orderDetail.OrderID).Data.Count < 1)
                {
                    _orderService.Delete(new Order { ID = orderDetail.OrderID });
                }
                return Json(_orderDetailService.Delete(new OrderDetail { ID = id }).Success);
            }
            return Json(false);
        }
    }
}
