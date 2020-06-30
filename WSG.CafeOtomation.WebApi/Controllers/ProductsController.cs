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
    public class ProductCategoriesController : ControllerBase
    {
        private IProductCategoryService _productCategoryService;
        public ProductCategoriesController(IProductCategoryService productCategoryService)
        {
            _productCategoryService = productCategoryService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _productCategoryService.GetAll();
            return Ok(result.Data);
        }
        [HttpGet("getbyid")]
        public IActionResult GetByID(int id)
        {
            var result = _productCategoryService.GetByID(id);
            return Ok(result.Data);
        }
        [HttpPost("add")]
        public IActionResult Add(ProductCategory productCategory)
        {
            var result = _productCategoryService.Add(productCategory);
            return Ok(result);
        }
        [HttpPost("update")]
        public IActionResult Update(ProductCategory productCategory)
        {
            var result = _productCategoryService.Update(productCategory);
            return Ok(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(ProductCategory productCategory)
        {
            var result = _productCategoryService.Delete(productCategory);
            return Ok(result);
        }
    }
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _productService.GetAll();
            return Ok(result.Data);
        }
        [HttpGet("getbycategoryid")]
        public IActionResult GetByCategoryID(int id)
        {
            var result = _productService.GetByCategory(id);
            return Ok(result.Data);
        }
        [HttpGet("getbyid")]
        public IActionResult Get(int id)
        {
            var result = _productService.GetByID(id);
            return Ok(result.Data);
        }
        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            return Ok(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Product product)
        {
            var result = _productService.Update(product);
            return Ok(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Product product)
        {
            var result = _productService.Delete(product);
            return Ok(result);
        }
    }
    [Route("api/[controller]")]
    [ApiController]
    public class ProductImagesController : ControllerBase
    {
        private IProductImageService _productImageService;
        public ProductImagesController(IProductImageService productImageService)
        {
            _productImageService = productImageService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _productImageService.GetAll();
            return Ok(result.Data);
        }
        [HttpGet("getbyproduct")]
        public IActionResult GetByProduct(int id)
        {
            var result = _productImageService.GetByProduct(id);
            return Ok(result.Data);
        }
        [HttpGet("getbyid")]
        public IActionResult GetByID(int id)
        {
            var result = _productImageService.GetByID(id);
            return Ok(result.Data);
        }
        [HttpPost("add")]
        public IActionResult Add(ProductImage productImage)
        {
            var result = _productImageService.Add(productImage);
            return Ok(result);
        }
        [HttpPost("update")]
        public IActionResult Update(ProductImage productImage)
        {
            var result = _productImageService.Update(productImage);
            return Ok(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(ProductImage productImage)
        {
            var result = _productImageService.Delete(productImage);
            return Ok(result);
        }
    }
    [Route("api/[controller]")]
    [ApiController]
    public class ProductDetailsController : ControllerBase
    {
        private IProductDetailService _productDetailService;
        public ProductDetailsController(IProductDetailService productDetailService)
        {
            _productDetailService = productDetailService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _productDetailService.GetAll();
            return Ok(result.Data);
        }
        [HttpGet("getbyproduct")]
        public IActionResult GetByProduct(int id)
        {
            var result = _productDetailService.GetByProductID(id);
            return Ok(result.Data);
        }
        [HttpGet("getbyid")]
        public IActionResult GetByID(int id)
        {
            var result = _productDetailService.GetByID(id);
            return Ok(result.Data);
        }
        [HttpPost("add")]
        public IActionResult Add(ProductDetail productDetail)
        {
            var result = _productDetailService.Add(productDetail);
            return Ok(result);
        }
        [HttpPost("update")]
        public IActionResult Update(ProductDetail productDetail)
        {
            var result = _productDetailService.Update(productDetail);
            return Ok(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(ProductDetail productDetail)
        {
            var result = _productDetailService.Delete(productDetail);
            return Ok(result);
        }
    }
}
