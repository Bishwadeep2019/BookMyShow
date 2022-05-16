using BookMyShow.DataModels;
using BookMyShow.Interface;
using BookMyShow.Models.CoreModels;

namespace BookMyShow.Services
{
    public class TheaterService: ITheaterService
    {
        private readonly AutoMapper.IMapper _mapper;
        public TheaterService(AutoMapper.IMapper mapper)
        {
            _mapper = mapper;
        }

        public Task<IEnumerable<TheaterDTO>> GetAll()
        {

            var databaseContent = new PetaPoco.Database("BookMyShow", "");
            var theaterdto = databaseContent.Query<Booking>("SELECT * FROM CityTheaters").ToList();
            return Task.FromResult(_mapper.Map<IEnumerable<TheaterDTO>>(theaterdto));
        }

        public TheaterDTO GetTheater(int id)
        {
            var databaseContent = new PetaPoco.Database("BookMyShow", "");
            var theaterDetail = databaseContent.Single<TheaterDTO>("SELECT * FROM CityTheaters WHERE Id = @0", id);
            return theaterDetail;
        }

        public Theater Insert(Theater theater)
        {
            var databaseContent = new PetaPoco.Database("BookMyShow", "");
            databaseContent.Insert(theater);
            return theater;
        }
    }
}
