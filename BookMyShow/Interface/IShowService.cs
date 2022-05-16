using BookMyShow.Models.CoreModels;
using BookMyShow.DataModels;

namespace BookMyShow.Interface
{
    public interface IShowService
    {
        Task<IEnumerable<ShowDTO>> GetAll();
        ShowDTO GetShow(int id);
        Show Insert(Show show);
    }
}
