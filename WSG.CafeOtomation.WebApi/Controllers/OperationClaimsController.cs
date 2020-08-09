using Microsoft.AspNetCore.Mvc;
using WizardSoftwareGroupsFramework.Core.Entities.Concrete;
using WSG.CafeOtomation.Business.Abstract;

namespace WSG.CafeOtomation.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationClaimsController : ControllerBase
    {
        private IOperationClaimService _operationClaimService;
        public OperationClaimsController(IOperationClaimService operationClaimService)
        {
            _operationClaimService = operationClaimService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _operationClaimService.GetAll();
            return Ok(result.Data);
        }
        [HttpGet("getbyid")]
        public IActionResult Get(int id)
        {
            var result = _operationClaimService.GetByID(id);
            return Ok(result.Data);
        }
        [HttpGet("getbyname")]
        public IActionResult Get(string name)
        {
            var result = _operationClaimService.GetByName(name);
            return Ok(result.Data);
        }
        [HttpPost("add")]
        public IActionResult Add(OperationClaim operationClaim)
        {
            var result = _operationClaimService.Add(operationClaim);
            return Ok(result.Message);
        }
        [HttpPost("update")]
        public IActionResult Update(OperationClaim operationClaim)
        {
            var result = _operationClaimService.Update(operationClaim);
            return Ok(result.Message);
        }
        [HttpPost("delete")]
        public IActionResult Delete(OperationClaim operationClaim)
        {
            var result = _operationClaimService.Delete(operationClaim);
            return Ok(result.Message);
        }
    }
}
