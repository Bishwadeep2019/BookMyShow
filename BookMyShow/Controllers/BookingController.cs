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
        private readonly IBookingService BookingService;
        public BookingController(IBookingService bookingservice)
        {
            BookingService = bookingservice;
        }

        [HttpGet("bookingdata")]
        public Task<IEnumerable<BookingDTO>> GetAllBookingData()
        {
            return BookingService.GetAllBooking();
        }
        [HttpGet("id")]
        public BookingDTO GetByBookingId(int id)
        {
            var booking = BookingService.GetBookingById(id);
            return booking;
        }
        
        [HttpPost("insert")]
        public Booking InsertBooking(Booking booking)
        {
            return BookingService.InsertBookingDetails(booking);
        }

    }
}

