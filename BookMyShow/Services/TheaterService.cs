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

            var databaseContent = new PetaPoco.Database("Server=DEAD-INSIDE;Database=BookMyShow;Trusted_Connection=True;", "System.Data.SqlClient");
            var theaterdto = databaseContent.Query<TheaterDTO>("SELECT * FROM theater").ToList();
            return Task.FromResult(_mapper.Map<IEnumerable<TheaterDTO>>(theaterdto));
        }

        public TheaterDTO GetTheater(int id)
        {
            var databaseContent = new PetaPoco.Database("Server=DEAD-INSIDE;Database=BookMyShow;Trusted_Connection=True;", "System.Data.SqlClient");
            var theaterDetail = databaseContent.Single<TheaterDTO>("SELECT * FROM theater WHERE Id = @0", id);
            return theaterDetail;
        }

        public Theater Insert(Theater theater)
        {
            var databaseContent = new PetaPoco.Database("Server=DEAD-INSIDE;Database=BookMyShow;Trusted_Connection=True;", "System.Data.SqlClient");
            databaseContent.Insert(theater);
            return theater;
        }

        public Task<IEnumerable<CityTheaterDTO>> GetAllCityTheater()
        {
            var databaseContent = new PetaPoco.Database("Server=DEAD-INSIDE;Database=BookMyShow;Trusted_Connection=True;", "System.Data.SqlClient");
            var citytheaterdto = databaseContent.Query<CityTheaterDTO>("SELECT * FROM CityTheaters").ToList();
            return Task.FromResult(_mapper.Map<IEnumerable<CityTheaterDTO>>(citytheaterdto));
        }

        public Task<IEnumerable<CityTheaterDTO>> GetByName(string cityName, int movieId)
        {
            var databaseContent = new PetaPoco.Database("Server=DEAD-INSIDE;Database=BookMyShow;Trusted_Connection=True;", "System.Data.SqlClient");
            var citytheaterdetails = databaseContent.Query<CityTheaterDTO>("SELECT * FROM CityTheaters WHERE cityName = @0 AND movieID = @1", cityName, movieId);
            return Task.FromResult(_mapper.Map<IEnumerable<CityTheaterDTO>>(citytheaterdetails));
        }
    }
}
