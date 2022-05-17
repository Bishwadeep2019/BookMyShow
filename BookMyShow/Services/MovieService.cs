using BookMyShow.Models.CoreModels;
using BookMyShow.DataModels;
using BookMyShow.Interface;

namespace BookMyShow.Services
{
    public class MovieService : IMovieService
    {
        private readonly AutoMapper.IMapper _mapper;
        public MovieService(AutoMapper.IMapper mapper)
        {
            _mapper = mapper;
        }
        public Task<IEnumerable<MovieDTO>> GetAll()
        {
            var databaseContent = new PetaPoco.Database("Server=DEAD-INSIDE;Database=BookMyShow;Trusted_Connection=True;", "System.Data.SqlClient");
            var moviedto = databaseContent.Query<Movie>("SELECT * FROM MoviesInCity").ToList();
            return Task.FromResult(_mapper.Map<IEnumerable<MovieDTO>>(moviedto));
        }

        public MovieDTO GetMovie(int id)
        {
            var databaseContent = new PetaPoco.Database("Server=DEAD-INSIDE;Database=BookMyShow;Trusted_Connection=True;", "System.Data.SqlClient");
            var movieDetails =  databaseContent.Single<MovieDTO>("SELECT * FROM Movie WHERE Id = @0", id);
            return movieDetails;
        }

        public Movie Insert(Movie movie)
        {
            var databaseContent = new PetaPoco.Database("Server=DEAD-INSIDE;Database=BookMyShow;Trusted_Connection=True;", "System.Data.SqlClient");
            databaseContent.Insert(movie);
            return movie;
        }
    }
}
