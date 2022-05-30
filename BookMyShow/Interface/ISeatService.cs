using BookMyShow.Models.CoreModels;
using BookMyShow.DataModels;

namespace BookMyShow.Interface
{
    public interface ISeatService
    {
        Task<IEnumerable<SeatDTO>> GetAllSeat();
        Task<IEnumerable<SeatDTO>> GetSeatByHallId(int hallId);
        Seat InsertBookedSeat(Seat seat);
    }
}
