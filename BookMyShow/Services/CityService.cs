using BookMyShow.DataModels;
using BookMyShow.Models.CoreModels;
using BookMyShow.Interface;
namespace BookMyShow.Services
{
    public class CityService: ICityService
    {
        private readonly AutoMapper.IMapper _mapper;

        private PetaPocoDB _petPocoDB;
        public CityService(AutoMapper.IMapper mapper, PetaPocoDB pb)
        {
            _mapper = mapper;
            this._petPocoDB = pb;
        }
        public Task<IEnumerable<City>> GetAllCity()
        {
            var databaseContext = new PetaPoco.Database("Server=DEAD-INSIDE;Database=BookMyShow;Trusted_Connection=True;", "System.Data.SqlClient");
            var citydto = databaseContext.Query<City>("Select * From City").ToList();
            Console.WriteLine(citydto);
            return Task.FromResult(_mapper.Map<IEnumerable<City>>(citydto));
        }

        public City InsertCityDetails(City city)
        {           
            this._petPocoDB.Insert(city);            
            return city;
        }
    }
}
