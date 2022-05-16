using BookMyShow.Models.CoreModels;
using BookMyShow.DataModels;
namespace BookMyShow.Interface
{
    public interface ICityService
    {
        Task<IEnumerable<CityDTO>> GetAll();
        City Insert(City city);
    }
}
