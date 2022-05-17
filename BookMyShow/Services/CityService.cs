using BookMyShow.DataModels;
using BookMyShow.Models.CoreModels;
using BookMyShow.Interface;
namespace BookMyShow.Services
{
    public class CityService: ICityService
    {
        private readonly AutoMapper.IMapper _mapper;
        public CityService(AutoMapper.IMapper mapper)
        {
            _mapper = mapper;
        }
        public Task<IEnumerable<City>> GetAll()
        {
            var databaseContent = new PetaPoco.Database("Server=DEAD-INSIDE;Database=BookMyShow;Trusted_Connection=True;", "System.Data.SqlClient");
            var citydto = databaseContent.Query<City>("SELECT * FROM City").ToList();
            return Task.FromResult(_mapper.Map<IEnumerable<City>>(citydto));
        }

        public City Insert(City city)
        {
            var databaseContent = new PetaPoco.Database("Server=DEAD-INSIDE;Database=BookMyShow;Trusted_Connection=True;", "System.Data.SqlClient");
            databaseContent.Insert(city);
            return city;
        }
    }
}
