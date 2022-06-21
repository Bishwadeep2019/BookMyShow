using BookMyShow.Models.CoreModels;
using BookMyShow.DataModels;

namespace BookMyShow.Interface
{
    public interface IShowService
    {
        Task<IEnumerable<ShowDTO>> GetAllShow();
        ShowDTO GetShowById(int id);
        Show InsertShowDetails(Show show);
    }
}
