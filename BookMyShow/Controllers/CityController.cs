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

        private readonly ICityService CityService;
        public CityController(ICityService cityservice)
        {
            CityService = cityservice;
        }
        [HttpGet]
        public Task<IEnumerable<City>> Get()
        {
            return CityService.GetAllCity();
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
            return CityService.InsertCityDetails(city);
        }

        //[HttpDelete("id")]
        //public Task<IEnumerable<MovieDTO>> DeleteData(int id)
        //{
        //    return _bookingservice.Delete(id);
        //}
    }
}

