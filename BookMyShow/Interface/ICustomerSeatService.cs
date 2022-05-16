using BookMyShow.DataModels;
using BookMyShow.Models.CoreModels;

namespace BookMyShow.Interface
{
    public interface ICustomerSeatService
    {
        Task<IEnumerable<CustomerSeatDTO>> GetAll();
        CustomerSeatDTO GetById(int id);
        CustomerSeat Insert(CustomerSeat customerSeat);
    }
}
