using BookMyShow.Models.CoreModels;
using BookMyShow.DataModels;
using BookMyShow.Interface;

namespace BookMyShow.Services
{
    public class MovieService : IMovieService
    {
        private readonly AutoMapper.IMapper _mapper;

        private PetaPocoDB _petPocoDB;
        public MovieService(AutoMapper.IMapper mapper, PetaPocoDB pb)
        {
            _mapper = mapper;
            this._petPocoDB = pb;
        }
        public Task<IEnumerable<MovieDTO>> GetAll()
        {
            var moviedto = this._petPocoDB.Query<MovieDTO>("SELECT * FROM Movie").ToList();
            return Task.FromResult(_mapper.Map<IEnumerable<MovieDTO>>(moviedto));
        }

        public MovieDTO GetMovieById(int id)
        {
            
            var movieDetails = this._petPocoDB.Single<MovieDTO>("SELECT * FROM Movie WHERE Id = @0", id);
            return movieDetails;
        }

        public Movie InsertMovieDetails(Movie movie)
        {
            this._petPocoDB.Insert(movie);
            return movie;
        }

        public Movie UpdateMovieDetails(Movie movie)
        {
            this._petPocoDB.Update(movie);
            return movie;
        }
    }
}
