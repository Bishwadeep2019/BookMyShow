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

        private readonly ITheaterHallService _theaterhallservice;
        public TheaterHallController(ITheaterHallService theaterhallservice)
        {
            _theaterhallservice = theaterhallservice;
        }
        [HttpGet]
        public Task<IEnumerable<TheaterHallDTO>> Get()
        {
            return _theaterhallservice.GetAll();
        }
        [HttpGet("id")]
        public async Task<IActionResult> GetById(int id)
        {
            var theaterHall = _theaterhallservice.GetTheaterHall(id);
            return Ok(theaterHall);
        }

        [HttpPost]
        public TheaterHall Create(TheaterHall theaterHall)
        {
            return _theaterhallservice.Insert(theaterHall);
        }

    }
}

