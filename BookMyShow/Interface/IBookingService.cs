using BookMyShow.Models.CoreModels;
using BookMyShow.DataModels;
namespace BookMyShow.Interface
{
    public interface IBookingService
    {
        Task<IEnumerable<BookingDTO>> GetAll();
        BookingDTO GetBookingById(int id);
        Booking Insert(Booking booking);
        //Task<IEnumerable<BookingDTO>> CancelBooking(int id);
    }
}
