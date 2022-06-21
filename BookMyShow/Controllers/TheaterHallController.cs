using Microsoft.AspNetCore.Mvc;
using BookMyShow.DataModels;
using BookMyShow.Interface;
using BookMyShow.Models.CoreModels;


namespace BookMyShow.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TheaterHallController : ControllerBase
    {

        private readonly ITheaterHallService TheaterHallService;
        public TheaterHallController(ITheaterHallService theaterhallservice)
        {
            TheaterHallService = theaterhallservice;
        }
        [HttpGet]
        public Task<IEnumerable<TheaterHallDTO>> Get()
        {
            return TheaterHallService.GetAll();
        }
        [HttpGet("id")]
        public async Task<IActionResult> GetById(int id)
        {
            var theaterHall = TheaterHallService.GetTheaterHall(id);
            return Ok(theaterHall);
        }

        [HttpPost]
        public TheaterHall Create(TheaterHall theaterHall)
        {
            return TheaterHallService.Insert(theaterHall);
        }

        [HttpGet("totalseats")]
        public async Task<IActionResult> GetSeats(int theaterId)
        {
            var totalSeats = TheaterHallService.GetTotalSeats(theaterId);
            return Ok(totalSeats);
        }

    }
}

