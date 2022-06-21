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

        private readonly ITheaterService TheaterService;
        public TheaterController(ITheaterService theaterservice)
        {
            TheaterService = theaterservice;
        }
        [HttpGet]
        public Task<IEnumerable<TheaterDTO>> Get()
        {
            return TheaterService.GetAllTheater();
        }
        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            var theater = TheaterService.GetTheater(id);
            return Ok(theater);
        }

        [HttpPost]
        public Theater Create(Theater  theater)
        {
            return TheaterService.InsertTheaterDetails(theater);
        }

        [HttpGet("theater")]
        public Task<IEnumerable<CityTheaterDTO>> GetCityTheater()
        {
            return TheaterService.GetAllCityTheater();
        }
        [HttpGet("name")]
        public Task<IEnumerable<CityTheaterDTO>> GetCityName(string name, int movieId)
        {
            return TheaterService.GetByName(name, movieId);

        }

    }
}

