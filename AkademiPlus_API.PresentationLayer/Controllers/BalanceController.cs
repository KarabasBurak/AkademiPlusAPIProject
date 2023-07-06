using AkademiPlusAPI.BusinessLayer.Abstract;
using AkademiPlusAPI.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AkademiPlus_API.PresentationLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BalanceController : ControllerBase
    {
        private readonly IBalanceService _balanceService;

        public BalanceController(IBalanceService balanceService)
        {
            _balanceService = balanceService;
        }
        [HttpGet]
        public IActionResult BalanceList()
        {
            var values = _balanceService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddBalance(Balance balance)
        {
            _balanceService.TInsert(balance);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteBalance(int id)
        {
            var values = _balanceService.TGetByID(id);
            _balanceService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateBalance(Balance balance)
        {
            _balanceService.TUpdate(balance);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetBalance(int id)
        {
            var values = _balanceService.TGetByID(id);
            return Ok(values);
        }
    }
}
