using BookMyShow.DataModels;
using BookMyShow.Models.CoreModels;
using BookMyShow.Interface;

namespace BookMyShow.Services
{
    public class SeatService : ISeatService
    {
        private readonly AutoMapper.IMapper _mapper;
        public SeatService(AutoMapper.IMapper mapper)
        {
            _mapper = mapper;
        }
        public Task<IEnumerable<SeatDTO>> GetAllSeat()
        {
            var databaseContent = new PetaPoco.Database("Server=DEAD-INSIDE;Database=BookMyShow;Trusted_Connection=True;", "System.Data.SqlClient");
            var seatdto = databaseContent.Query<SeatDTO>("SELECT * FROM Seat").ToList();
            return Task.FromResult(_mapper.Map<IEnumerable<SeatDTO>>(seatdto));
        }

        public Task<IEnumerable<SeatDTO>> GetSeatByHallId(int hallId)
        {
            var databaseContent = new PetaPoco.Database("Server=DEAD-INSIDE;Database=BookMyShow;Trusted_Connection=True;", "System.Data.SqlClient");
            var seatdto = databaseContent.Query<SeatDTO>("SELECT * FROM Seat WHERE HallId = @0",hallId).ToList();
            return Task.FromResult(_mapper.Map<IEnumerable<SeatDTO>>(seatdto));
        }

        public Seat InsertBookedSeat(Seat seat)
        {
            var databaseContent = new PetaPoco.Database("Server=DEAD-INSIDE;Database=BookMyShow;Trusted_Connection=True;", "System.Data.SqlClient");
            databaseContent.Insert(seat);
            return seat;
        }
    }
}
