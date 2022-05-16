using BookMyShow.Models.CoreModels;
using BookMyShow.DataModels;
namespace BookMyShow.Interface
{
    public interface ICustomerService
    {
        Task<IEnumerable<CustomerDTO>> GetAll();
        CustomerDTO GetCustomer(int id);

        Customer Insert(Customer customer);
    }
}
