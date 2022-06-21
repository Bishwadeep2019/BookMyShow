using BookMyShow.Models.CoreModels;
using BookMyShow.DataModels;
namespace BookMyShow.Interface
{
    public interface IMovieService
    {
        Task<IEnumerable<MovieDTO>> GetAll();
        MovieDTO GetMovieById(int id);

        Movie InsertMovieDetails(Movie movie);

        Movie UpdateMovieDetails(Movie movie);
    }
}
