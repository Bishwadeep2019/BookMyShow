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

        private readonly ICustomerSeatService _customerseatservice;
        public CustomerSeatController(ICustomerSeatService customerseatservice)
        {
            _customerseatservice = customerseatservice;
        }
        [HttpGet]
        public Task<IEnumerable<CustomerSeatDTO>> Get()
        {
            return _customerseatservice.GetAll();
        }
        [HttpGet("id")]
        public async Task<IActionResult> GetSeatById(int id)
        {
            var customerseat = _customerseatservice.GetById(id);
            return Ok(customerseat);
        }

        [HttpPost]
        public CustomerSeat Create(CustomerSeat customerseat)
        {
            return _customerseatservice.Insert(customerseat);
        }

    }
}

