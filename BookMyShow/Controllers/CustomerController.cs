using Microsoft.AspNetCore.Mvc;
using BookMyShow.DataModels;
using BookMyShow.Interface;
using BookMyShow.Models.CoreModels;


namespace BookMyShow.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private readonly ICustomerService _customerservice;
        public CustomerController(ICustomerService customerservice)
        {
            _customerservice = customerservice;
        }
        [HttpGet]
        public Task<IEnumerable<CustomerDTO>> Get()
        {
            return _customerservice.GetAll();
        }
        [HttpGet("id")]
        public async Task<IActionResult> GetById(int id)
        {
            var customer = _customerservice.GetCustomer(id);
            return Ok(customer);
        }

        [HttpPost]
        public Customer Create(Customer customer)
        {
            return _customerservice.Insert(customer);
        }

        //[HttpDelete("id")]
        //public Task<IEnumerable<MovieDTO>> DeleteData(int id)
        //{
        //    return _bookingservice.Delete(id);
        //}
    }
}

