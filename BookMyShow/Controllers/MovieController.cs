using Microsoft.AspNetCore.Mvc;
using BookMyShow.DataModels;
using BookMyShow.Interface;
using BookMyShow.Models.CoreModels;


namespace BookMyShow.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {

        private readonly IMovieService MovieService;
        public MovieController(IMovieService movieservice)
        {
            MovieService = movieservice;
        }
        [HttpGet]
        public Task<IEnumerable<MovieDTO>> Get()
        {
            return MovieService.GetAll();
        }
        [HttpGet("id")]
        public async Task<IActionResult> GetById(int id)
        {
            var movie = MovieService.GetMovieById(id);
            return Ok(movie);
        }

        [HttpPost("movieDetails")]
        public Movie Create(Movie movie)
        {
            return MovieService.InsertMovieDetails(movie);
        }

        [HttpPut]
        public async Task<IActionResult> Update(Movie movie)
        {
            var movies =  MovieService.UpdateMovieDetails(movie);
            return Ok(movies);
        }

    }
}

