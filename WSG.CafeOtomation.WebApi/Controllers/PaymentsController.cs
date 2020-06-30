using Microsoft.AspNetCore.Mvc;
using WSG.CafeOtomation.Business.Abstract;
using WSG.CafeOtomation.Entities.Concrete;

namespace WSG.CafeOtomation.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {
        private IPaymentService _paymentService;
        public PaymentsController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _paymentService.GetAll();
            return Ok(result.Data);
        }
        [HttpGet("getbyuserid")]
        public IActionResult Get(int userId)
        {
            var result = _paymentService.GetByUserID(userId);
            return Ok(result.Data);
        }
        [HttpPost("add")]
        public IActionResult Add(Payment payment)
        {
            var result = _paymentService.Add(payment);
            return Ok(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Payment payment)
        {
            var result = _paymentService.Update(payment);
            return Ok(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Payment payment)
        {
            var result = _paymentService.Delete(payment);
            return Ok(result);
        }
    }
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentDetailsController : ControllerBase
    {
        private IPaymentDetailService _paymentDetailService;
        public PaymentDetailsController(IPaymentDetailService paymentDetailService)
        {
            _paymentDetailService = paymentDetailService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _paymentDetailService.GetAll();
            return Ok(result.Data);
        }
        [HttpGet("getbypaymentid")]
        public IActionResult GetAll(int paymentId)
        {
            var result = _paymentDetailService.GetByPaymentID(paymentId);
            return Ok(result.Data);
        }
        [HttpPost("add")]
        public IActionResult Add(PaymentDetail paymentDetail)
        {
            var result = _paymentDetailService.Add(paymentDetail);
            return Ok(result);
        }
        [HttpPost("update")]
        public IActionResult Update(PaymentDetail paymentDetail)
        {
            var result = _paymentDetailService.Update(paymentDetail);
            return Ok(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(PaymentDetail paymentDetail)
        {
            var result = _paymentDetailService.Delete(paymentDetail);
            return Ok(result);
        }
    }
}
