﻿using AkademiPlusAPI.BusinessLayer.Abstract;
using AkademiPlusAPI.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AkademiPlus_API.PresentationLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpGet]
        public ActionResult CustomerList()
        {
            var values=_customerService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CustomerAdd(Customer customer)
        {
            _customerService.TInsert(customer);
            return Ok();
        }
        [HttpDelete]
        public IActionResult CustomerDelete(int id)
        {
            var values=_customerService.TGetByID(id);
            _customerService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult CustomerUpdate(Customer customer)
        {
            _customerService.TUpdate(customer);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetCustomer(int id)
        {
            var values= _customerService.TGetByID(id);
            return Ok(values);
        }
        [HttpGet("GetCustomerCounts")]
        public IActionResult GetCustomerCounts()
        {
            return Ok(_customerService.TGetCustomerCounts());
        }
    }
}
