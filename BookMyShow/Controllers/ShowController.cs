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

        private readonly IShowService ShowService;
        public ShowController(IShowService showservice)
        {
            ShowService = showservice;
        }
        [HttpGet]
        public Task<IEnumerable<ShowDTO>> Get()
        {
            return ShowService.GetAllShow();
        }
        [HttpGet("id")]
        public async Task<IActionResult> GetById(int id)
        {
            var show = ShowService.GetShowById(id);
            return Ok(show);
        }

        [HttpPost]
        public Show Create(Show show)
        {
            return ShowService.InsertShowDetails(show);
        }

    }
}

