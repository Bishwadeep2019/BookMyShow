using Microsoft.AspNetCore.Mvc;
using BookMyShow.DataModels;
using BookMyShow.Interface;
using BookMyShow.Models.CoreModels;

namespace BookMyShow.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {

        private readonly ICityService _cityservice;
        public CityController(ICityService cityservice)
        {
            _cityservice = cityservice;
        }
        [HttpGet]
        public Task<IEnumerable<City>> Get()
        {
            return _cityservice.GetAll();
        }
        //[HttpGet("id")]
        //public async Task<IActionResult> GetById(int id)
        //{
        //    var booking = _cityservice.
        //    return Ok(booking);
        //}

        [HttpPost]
        public City Create(City city)
        {
            return _cityservice.Insert(city);
        }

        //[HttpDelete("id")]
        //public Task<IEnumerable<MovieDTO>> DeleteData(int id)
        //{
        //    return _bookingservice.Delete(id);
        //}
    }
}

