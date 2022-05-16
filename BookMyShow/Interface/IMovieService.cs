using BookMyShow.Models.CoreModels;
using BookMyShow.DataModels;
namespace BookMyShow.Interface
{
    public interface IMovieService
    {
        Task<IEnumerable<MovieDTO>> GetAll();
        MovieDTO GetMovie(int id);

        Movie Insert(Movie movie);
    }
}
