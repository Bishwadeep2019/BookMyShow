using BookMyShow.Models.CoreModels;
using BookMyShow.DataModels;
namespace BookMyShow.Interface
{
    public interface ICityService
    {
        Task<IEnumerable<City>> GetAllCity();
        City InsertCityDetails(City city);
    }
}
