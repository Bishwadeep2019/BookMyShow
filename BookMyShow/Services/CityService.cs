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
        public Task<IEnumerable<CityDTO>> GetAll()
        {
            var databaseContent = new PetaPoco.Database("BookMyShow", "");
            var citydto = databaseContent.Query<City>("SELECT * FROM City").ToList();
            return Task.FromResult(_mapper.Map<IEnumerable<CityDTO>>(citydto));
        }

        public City Insert(City city)
        {
            var databaseContent = new PetaPoco.Database("BookMyShow", "");
            databaseContent.Insert(city);
            return city;
        }
    }
}
