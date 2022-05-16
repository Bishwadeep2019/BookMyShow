using Microsoft.AspNetCore.Mvc;
using BookMyShow.DataModels;
using BookMyShow.Interface;
using BookMyShow.Models.CoreModels;


namespace BookMyShow.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
       
        private readonly IBookingService _bookingservice;
        public BookingController(IBookingService bookingservice)
        {
            _bookingservice = bookingservice;
        }
        [HttpGet]
        public Task<IEnumerable<BookingDTO>> Get()
        {
            return _bookingservice.GetAll();
        }
        [HttpGet("id")]
        public async Task<IActionResult> GetById(int id)
        {
            var booking = _bookingservice.GetBookingById(id);
            return Ok(booking);
        }
        
        [HttpPost]
        public Booking Create(Booking booking)
        {
            return _bookingservice.Insert(booking);
        }

        //[HttpDelete("id")]
        //public Task<IEnumerable<MovieDTO>> DeleteData(int id)
        //{
        //    return _bookingservice.Delete(id);
        //}
    }
}

