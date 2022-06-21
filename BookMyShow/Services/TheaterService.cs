using BookMyShow.DataModels;
using BookMyShow.Interface;
using BookMyShow.Models.CoreModels;

namespace BookMyShow.Services
{
    public class TheaterService: ITheaterService
    {
        private readonly AutoMapper.IMapper _mapper;
        private PetaPocoDB _petPocoDB;
        public TheaterService(AutoMapper.IMapper mapper, PetaPocoDB pb)
        {
            _mapper = mapper;
            this._petPocoDB = pb;
        }

        public Task<IEnumerable<TheaterDTO>> GetAllTheater()
        {
            var theaterdto = this._petPocoDB.Query<TheaterDTO>("SELECT * FROM theater").ToList();
            return Task.FromResult(_mapper.Map<IEnumerable<TheaterDTO>>(theaterdto));
        }

        public TheaterDTO GetTheater(int id)
        {
            var theaterDetail = this._petPocoDB.Single<TheaterDTO>("SELECT * FROM theater WHERE Id = @0", id);
            return theaterDetail;
        }

        public Theater InsertTheaterDetails(Theater theater)
        {
            this._petPocoDB.Insert(theater);
            return theater;
        }

        public Task<IEnumerable<CityTheaterDTO>> GetAllCityTheater()
        {
            var citytheaterdto = this._petPocoDB.Query<CityTheaterDTO>("SELECT * FROM CityTheaters").ToList();
            return Task.FromResult(_mapper.Map<IEnumerable<CityTheaterDTO>>(citytheaterdto));
        }

        public Task<IEnumerable<CityTheaterDTO>> GetByName(string cityName, int movieId)
        {
            var databaseContext = new PetaPoco.Database("Server=DEAD-INSIDE;Database=BookMyShow;Trusted_Connection=True;", "System.Data.SqlClient");

            var citytheaterdetails = databaseContext.Query<CityTheaterDTO>("SELECT * FROM CityTheaters WHERE cityName = @0 AND movieID = @1", cityName, movieId);
            return Task.FromResult(_mapper.Map<IEnumerable<CityTheaterDTO>>(citytheaterdetails));
        }
    }
}
