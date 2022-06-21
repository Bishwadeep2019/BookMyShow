using Microsoft.AspNetCore.Mvc;
using BookMyShow.DataModels;
using BookMyShow.Interface;
using BookMyShow.Models.CoreModels;


namespace BookMyShow.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerSeatController : ControllerBase
    {

        private readonly ICustomerSeatService CustomerSeatService;
        public CustomerSeatController(ICustomerSeatService customerseatservice)
        {
            CustomerSeatService = customerseatservice;
        }
        [HttpGet]
        public Task<IEnumerable<CustomerSeatDTO>> Get()
        {
            return CustomerSeatService.GetAll();
        }
        [HttpGet("id")]
        public async Task<IActionResult> GetSeatById(int id)
        {
            var customerseat = CustomerSeatService.GetById(id);
            return Ok(customerseat);
        }

        [HttpPost]
        public CustomerSeat Create(CustomerSeat customerseat)
        {
            return CustomerSeatService.Insert(customerseat);
        }

    }
}

