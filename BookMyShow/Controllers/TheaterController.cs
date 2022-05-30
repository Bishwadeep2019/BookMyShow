using Microsoft.AspNetCore.Mvc;
using BookMyShow.DataModels;
using BookMyShow.Interface;
using BookMyShow.Models.CoreModels;


namespace BookMyShow.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TheaterController : ControllerBase
    {

        private readonly ITheaterService _theaterservice;
        public TheaterController(ITheaterService theaterservice)
        {
            _theaterservice = theaterservice;
        }
        [HttpGet]
        public Task<IEnumerable<TheaterDTO>> Get()
        {
            return _theaterservice.GetAll();
        }
        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            var theater = _theaterservice.GetTheater(id);
            return Ok(theater);
        }

        [HttpPost]
        public Theater Create(Theater  theater)
        {
            return _theaterservice.Insert(theater);
        }

        [HttpGet("theater")]
        public Task<IEnumerable<CityTheaterDTO>> GetCityTheater()
        {
            return _theaterservice.GetAllCityTheater();
        }
        [HttpGet("name")]
        public Task<IEnumerable<CityTheaterDTO>> GetCityName(string name, int movieId)
        {
            return _theaterservice.GetByName(name, movieId);

        }

    }
}

