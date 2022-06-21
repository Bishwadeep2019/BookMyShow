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

        private readonly ICustomerService CustomerService;
        public CustomerController(ICustomerService customerservice)
        {
            CustomerService = customerservice;
        }
        [HttpGet]
        public Task<IEnumerable<CustomerDTO>> Get()
        {
            return CustomerService.GetAllCustomer();
        }
        [HttpGet("id")]
        public async Task<IActionResult> GetById(int id)
        {
            var customer = CustomerService.GetCustomerById(id);
            return Ok(customer);
        }

        [HttpPost]
        public Customer Create(Customer customer)
        {
            return CustomerService.InsertCustomerDetails(customer);
        }

        //[HttpDelete("id")]
        //public Task<IEnumerable<MovieDTO>> DeleteData(int id)
        //{
        //    return _bookingservice.Delete(id);
        //}
    }
}

