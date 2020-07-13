using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WSG.CafeOtomation.Business.Abstract;
using WSG.CafeOtomation.Entities.Concrete;

namespace WSG.CafeOtomation.MVCWebUI.Controllers
{
    public class CustomerDeskController : Controller
    {
        private IProductService _productService;
        private IProductCategoryService _productCategoryService;
        private IProductImageService _productImageService;
        public CustomerDeskController(IProductService productService, IProductCategoryService productCategoryService, IProductImageService productImageService)
        {
            _productService = productService;
            _productCategoryService = productCategoryService;
            _productImageService = productImageService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MenuCategoryIndex()
        {
            return View(_productCategoryService.GetAll().Data.OrderBy(x => x.Order));
        }
        public IActionResult MenuIndex(int categoryID)
        {
            return View(_productService.GetByCategory(categoryID).Data);
        }
        public IActionResult CreateOrder()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateOrder(OrderDetail orderDetail)
        {
            return Redirect("");
        }
    }
}
