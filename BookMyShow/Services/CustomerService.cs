using BookMyShow.DataModels;
using BookMyShow.Interface;
using BookMyShow.Models.CoreModels;

namespace BookMyShow.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly AutoMapper.IMapper _mapper;
        public CustomerService(AutoMapper.IMapper mapper)
        {
            _mapper = mapper;
        }
        public Task<IEnumerable<CustomerDTO>> GetAllCustomer()
        {
            var databaseContext = new PetaPoco.Database("Server=DEAD-INSIDE;Database=BookMyShow;Trusted_Connection=True;", "System.Data.SqlClient");
            var customerdto =  databaseContext.Query<CustomerDTO>("Select * From Customer").ToList();
            return Task.FromResult(_mapper.Map<IEnumerable<CustomerDTO>>(customerdto));    
        }

        public CustomerDTO GetCustomerById(int id)
        {
            var databaseContext = new PetaPoco.Database("Server=DEAD-INSIDE;Database=BookMyShow;Trusted_Connection=True;", "System.Data.SqlClient");
            var customerDeatils = databaseContext.Single<CustomerDTO>("SELECT * FROM Customer WHERE Id = @0", id);
            return customerDeatils;
        }

        public Customer InsertCustomerDetails(Customer customer)
        {
            var databaseContext = new PetaPoco.Database("Server=DEAD-INSIDE;Database=BookMyShow;Trusted_Connection=True;", "System.Data.SqlClient");
            databaseContext.Insert(customer);
            return customer;
        }
    }
}
