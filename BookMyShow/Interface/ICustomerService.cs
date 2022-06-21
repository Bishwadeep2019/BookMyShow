using BookMyShow.Models.CoreModels;
using BookMyShow.DataModels;
namespace BookMyShow.Interface
{
    public interface ICustomerService
    {
        Task<IEnumerable<CustomerDTO>> GetAllCustomer();
        CustomerDTO GetCustomerById(int id);

        Customer InsertCustomerDetails(Customer customer);
    }
}
