using BookMyShow.Models.CoreModels;
using BookMyShow.DataModels;

namespace BookMyShow.Interface
{
    public interface ITheaterHallService
    {
        Task<IEnumerable<TheaterHallDTO>> GetAll();
        TheaterHallDTO GetTheaterHall(int id);
        TheaterHall Insert(TheaterHall theaterHall);
    }
}
