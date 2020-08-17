using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using WizardSoftwareGroupsFramework.Core.Utilities.Result.Abstract;
using WSG.CafeOtomation.Business.Abstract;
using WSG.CafeOtomation.Entities.Concrete;
using WSG.CafeOtomation.Entities.Dtos;

namespace WSG.CafeOtomation.MVCWebUI.Controllers
{
    public class CustomerDeskController : Controller
    {
        private IProductService _productService;
        private IProductTypeService _productTypeService;
        private IProductCategoryService _productCategoryService;
        private IProductImageService _productImageService;
        private IOrderService _orderService;
        private IOrderDetailService _orderDetailService;
        private IOrderDetailTypeService _orderDetailTypeService;
        private IDeskService _deskService;
        public CustomerDeskController(IProductService productService,
            IProductCategoryService productCategoryService,
            IProductImageService productImageService,
            IOrderService orderService,
            IOrderDetailService orderDetailService,
            IDeskService deskService,
            IProductTypeService productTypeService,
            IOrderDetailTypeService orderDetailTypeService)
        {
            _productService = productService;
            _productCategoryService = productCategoryService;
            _productImageService = productImageService;
            _orderService = orderService;
            _orderDetailService = orderDetailService;
            _deskService = deskService;
            _productTypeService = productTypeService;
            _orderDetailTypeService = orderDetailTypeService;
        }
        public IActionResult DeskIndex()
        {
            var data = _deskService.GetAll(x => x.IsActive).Data;
            return View(data);
        }
        public IActionResult Index(string deskUniqueID)
        {
            ViewBag.DeskUniqueID = deskUniqueID;
            return View();
        }
        public IActionResult MenuCategoryIndex(string deskUniqueID)
        {
            ViewBag.DeskUniqueID = deskUniqueID;
            var data = _productCategoryService.GetAll().Data.OrderBy(x => x.Order);
            return View(data);
        }
        public IActionResult MenuIndex(string categoryName, int categoryID, string deskUniqueID)
        {
            ViewBag.Title = categoryName;
            ViewBag.DeskUniqueID = deskUniqueID;
            ViewBag.ProductTypes = _productTypeService;
            return View(_productService.GetByCategory(categoryID).Data);
        }
        public IActionResult ManuIndexPopup(int id, string deskUniqueID)
        {
            ViewBag.DeskUniqueID = deskUniqueID;
            ViewBag.ProductTypes = _productTypeService;
            var data = _productService.GetByID(id).Data;
            ViewBag.Name = data.Name;
            ViewBag.ID = id;
            return PartialView();
        }
        public IActionResult OrderStatusIndex(string deskUniqueID)
        {
            ViewBag.DeskUniqueID = deskUniqueID;
            var desk = _deskService.GetByUnique(deskUniqueID);
            var order = _orderService.GetByDesk(desk.Data.ID).Data.Where(x => x.OrderPayStatus == OrderPayStatus.Open);
            var data = _orderDetailService.GetAll(x => x.OrderID == order.SingleOrDefault().ID).Data;
            return View(data);
        }

        [HttpPost]
        public IActionResult CreateOrder(CustomerOrderCreateDto customerOrderCreateDto)
        {
            var desk = _deskService.GetByUnique(customerOrderCreateDto.DeskUniqueId).Data;
            var product = _productService.GetByID(customerOrderCreateDto.ProductID).Data;
            var order = _orderService.GetByDesk(desk.ID).Data.Where(x => x.OrderPayStatus == OrderPayStatus.Open);
            IResult result;
            if (order.Count() < 1)
            {
                var orderCreate = new Order
                {
                    TotalPrice = customerOrderCreateDto.Amount * product.UnitPrice,
                    DeskID = desk.ID,
                    CreateDate = DateTime.Now
                };
                result = _orderService.Add(orderCreate);
                if (result.Success)
                {
                    var data = new OrderDetail
                    {
                        Amount = customerOrderCreateDto.Amount,
                        EOrderStatus = OrderStatus.Waiting,
                        OrderID = orderCreate.ID,
                        ProductID = product.ID,
                        TotalPrice = customerOrderCreateDto.Amount * product.UnitPrice,
                        CreateDate = DateTime.Now
                    };
                    result = _orderDetailService.Add(data);
                    if (customerOrderCreateDto.ProductTypes.Count > 0)
                    {
                        foreach (var item in customerOrderCreateDto.ProductTypes)
                        {
                            _orderDetailTypeService.Add(new OrderDetailType
                            {
                                OrderDetailID = data.ID,
                                ProductTypeID = item
                            });
                        }
                    }
                }
                return Json(result);
            }
            else
            {
                var data = new OrderDetail
                {
                    Amount = customerOrderCreateDto.Amount,
                    EOrderStatus = OrderStatus.Waiting,
                    OrderID = order.SingleOrDefault().ID,
                    ProductID = product.ID,
                    TotalPrice = customerOrderCreateDto.Amount * product.UnitPrice,
                    CreateDate = DateTime.Now
                };
                result = _orderDetailService.Add(data);
                if (customerOrderCreateDto.ProductTypes != null)
                {
                    if (customerOrderCreateDto.ProductTypes.Count > 0)
                    {
                        foreach (var item in customerOrderCreateDto.ProductTypes)
                        {
                            _orderDetailTypeService.Add(new OrderDetailType
                            {
                                OrderDetailID = data.ID,
                                ProductTypeID = item
                            });
                        }
                    }
                }
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
        [HttpGet]
        public JsonResult GetProductTypeData(int id)
        {
            return Json(_productTypeService.GetByProduct(id).Data);
        }
    }
}
