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
            var databaseContent = new PetaPoco.Database("BookMyShow", "");
            var moviedto = databaseContent.Query<Movie>("SELECT * FROM MoviesInCity").ToList();
            return Task.FromResult(_mapper.Map<IEnumerable<MovieDTO>>(moviedto));
        }

        public MovieDTO GetMovie(int id)
        {
            var databaseContent = new PetaPoco.Database("BookMyShow", "");
            var movieDetails =  databaseContent.Single<MovieDTO>("SELECT * FROM Movie WHERE Id = @0", id);
            return movieDetails;
        }

        public Movie Insert(Movie movie)
        {
            var databaseContent = new PetaPoco.Database("BookMyShow", "");
            databaseContent.Insert(movie);
            return movie;
        }
    }
}
