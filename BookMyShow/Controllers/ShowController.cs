using Microsoft.AspNetCore.Mvc;
using BookMyShow.DataModels;
using BookMyShow.Interface;
using BookMyShow.Models.CoreModels;


namespace BookMyShow.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowController : ControllerBase
    {

        private readonly IShowService _showservice;
        public ShowController(IShowService showservice)
        {
            _showservice = showservice;
        }
        [HttpGet]
        public Task<IEnumerable<ShowDTO>> Get()
        {
            return _showservice.GetAll();
        }
        [HttpGet("id")]
        public async Task<IActionResult> GetById(int id)
        {
            var show = _showservice.GetShow(id);
            return Ok(show);
        }

        [HttpPost]
        public Show Create(Show show)
        {
            return _showservice.Insert(show);
        }

    }
}

