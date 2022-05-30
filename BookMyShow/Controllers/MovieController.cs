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

        private readonly IMovieService _movieservice;
        public MovieController(IMovieService movieservice)
        {
            _movieservice = movieservice;
        }
        [HttpGet]
        public Task<IEnumerable<MovieDTO>> Get()
        {
            return _movieservice.GetAll();
        }
        [HttpGet("id")]
        public async Task<IActionResult> GetById(int id)
        {
            var movie = _movieservice.GetMovie(id);
            return Ok(movie);
        }

        [HttpPost]
        public Movie Create(Movie movie)
        {
            return _movieservice.Insert(movie);
        }

        [HttpPut]
        public async Task<IActionResult> Update(Movie movie)
        {
            var movies =  _movieservice.Update(movie);
            return Ok(movies);
        }

    }
}

