using BookMyShow.Models.CoreModels;
using BookMyShow.DataModels;
namespace BookMyShow.Interface
{
    public interface IBookingService
    {
        Task<IEnumerable<BookingDTO>> GetAllBooking();
        BookingDTO GetBookingById(int id);
        Booking InsertBookingDetails(Booking booking);
        
    }
}
