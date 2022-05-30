using Microsoft.AspNetCore.Mvc;
using BookMyShow.DataModels;
using BookMyShow.Interface;
using BookMyShow.Models.CoreModels;

namespace BookMyShow.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeatController : ControllerBase
    {
        private readonly ISeatService _seatservice;
        public SeatController(ISeatService seatservice)
        {
            _seatservice = seatservice;
        }
        [HttpGet]
        public Task<IEnumerable<SeatDTO>> Get()
        {
            return _seatservice.GetAllSeat();
        }
        [HttpGet("hallId")]
        public Task<IEnumerable<SeatDTO>> GetById(int hallId)
        {
            return _seatservice.GetSeatByHallId(hallId);
        }

        [HttpPost]
        public Seat Create(Seat seat)
        {
            return _seatservice.InsertBookedSeat(seat);
        }
    }
}
