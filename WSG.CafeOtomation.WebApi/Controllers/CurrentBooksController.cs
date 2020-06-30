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
    public class CustomerController : ControllerBase
    {
        private ICustomerService  _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _customerService.GetAll();
            return Ok(result.Data);
        }
        [HttpGet("getbyid")]
        public IActionResult GetByID(int id)
        {
            var result = _customerService.GetByID(id);
            return Ok(result.Data);
        }
        [HttpPost("add")]
        public IActionResult Add(Customer customer)
        {
            var result = _customerService.Add(customer);
            return Ok(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Customer customer)
        {
            var result = _customerService.Update(customer);
            return Ok(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Customer customer)
        {
            var result = _customerService.Delete(customer);
            return Ok(result);
        }
    }
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private ISupplierService _supplierService;
        public SupplierController(ISupplierService supplierService)
        {
            _supplierService = supplierService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _supplierService.GetAll();
            return Ok(result.Data);
        }
        [HttpGet("getbyid")]
        public IActionResult GetByID(int id)
        {
            var result = _supplierService.GetByID(id);
            return Ok(result.Data);
        }
        [HttpPost("add")]
        public IActionResult Add(Supplier supplier)
        {
            var result = _supplierService.Add(supplier);
            return Ok(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Supplier supplier)
        {
            var result = _supplierService.Update(supplier);
            return Ok(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Supplier supplier)
        {
            var result = _supplierService.Delete(supplier);
            return Ok(result);
        }
    }
    [Route("api/[controller]")]
    [ApiController]
    public class CurrentBooksController : ControllerBase
    {
        private ICurrentBookService _currentBookService;
        public CurrentBooksController(ICurrentBookService currentBookService)
        {
            _currentBookService = currentBookService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _currentBookService.GetAll();
            return Ok(result.Data);
        }
        [HttpGet("getbyid")]
        public IActionResult GetByID(int id)
        {
            var result = _currentBookService.GetByID(id);
            return Ok(result.Data);
        }
        [HttpPost("add")]
        public IActionResult Add(CurrentBook currentBook)
        {
            var result = _currentBookService.Add(currentBook);
            return Ok(result);
        }
        [HttpPost("update")]
        public IActionResult Update(CurrentBook currentBook)
        {
            var result = _currentBookService.Update(currentBook);
            return Ok(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(CurrentBook currentBook)
        {
            var result = _currentBookService.Delete(currentBook);
            return Ok(result);
        }
    }
    [Route("api/[controller]")]
    [ApiController]
    public class CurrentBookDetailsController : ControllerBase
    {
        private ICurrentBookDetailService _currentBookDetailService;
        public CurrentBookDetailsController(ICurrentBookDetailService currentBookDetailService)
        {
            _currentBookDetailService = currentBookDetailService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _currentBookDetailService.GetAll();
            return Ok(result.Data);
        }
        [HttpGet("getbycurrentid")]
        public IActionResult GetByCurrentID(int id)
        {
            var result = _currentBookDetailService.GetByCurrentID(id);
            return Ok(result.Data);
        }
        [HttpPost("add")]
        public IActionResult Add(CurrentBookDetail currentBookDetail)
        {
            var result = _currentBookDetailService.Add(currentBookDetail);
            return Ok(result);
        }
        [HttpPost("update")]
        public IActionResult Update(CurrentBookDetail currentBookDetail)
        {
            var result = _currentBookDetailService.Update(currentBookDetail);
            return Ok(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(CurrentBookDetail currentBookDetail)
        {
            var result = _currentBookDetailService.Delete(currentBookDetail);
            return Ok(result);
        }
    }
}
