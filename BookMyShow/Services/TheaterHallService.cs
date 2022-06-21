using BookMyShow.Models.CoreModels;
using BookMyShow.DataModels;
using BookMyShow.Interface;

namespace BookMyShow.Services
{
    public class TheaterHallService: ITheaterHallService
    {
        private readonly AutoMapper.IMapper _mapper;
        private PetaPocoDB _petPocoDB;
        public TheaterHallService(AutoMapper.IMapper mapper, PetaPocoDB pb)
        {
            _mapper = mapper;
            this._petPocoDB = pb;
        }

        public Task<IEnumerable<TheaterHallDTO>> GetAll()
        {
            var theaterhalldto = this._petPocoDB.Query<TheaterHallDTO>("SELECT * FROM TheaterHall").ToList();
            return Task.FromResult(_mapper.Map<IEnumerable<TheaterHallDTO>>(theaterhalldto));
        }

        public TheaterHallDTO GetTheaterHall(int id)
        {
            var theaterHallDetails = this._petPocoDB.Single<TheaterHallDTO>("SELECT * FROM TheaterHall WHERE Id = @0", id);
            return theaterHallDetails;
        }

        public TheaterHall Insert(TheaterHall theaterHall)
        {
            this._petPocoDB.Insert(theaterHall);
            return theaterHall;
        }

        public TotalSeatsDTO GetTotalSeats(int theaterId)
        {
            var totalSeats = this._petPocoDB.Single<TotalSeatsDTO>("SELECT * FROM TotalSeats WHERE  theaterId = @0", theaterId);
            return totalSeats;
        }

    }
}
