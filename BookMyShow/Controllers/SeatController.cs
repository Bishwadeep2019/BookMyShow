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
        private readonly ISeatService SeatService;
        public SeatController(ISeatService seatservice)
        {
            SeatService = seatservice;
        }
        [HttpGet]
        public Task<IEnumerable<SeatDTO>> Get()
        {
            return SeatService.GetAllSeat();
        }
        [HttpGet("hallId")]
        public Task<IEnumerable<SeatDTO>> GetById(int hallId)
        {
            return SeatService.GetSeatByHallId(hallId);
        }

        [HttpPost]
        public Seat Create(Seat seat)
        {
            return SeatService.InsertBookedSeat(seat);
        }
    }
}
