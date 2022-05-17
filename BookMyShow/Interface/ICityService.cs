using BookMyShow.Models.CoreModels;
using BookMyShow.DataModels;
namespace BookMyShow.Interface
{
    public interface ICityService
    {
        Task<IEnumerable<City>> GetAll();
        City Insert(City city);
    }
}
