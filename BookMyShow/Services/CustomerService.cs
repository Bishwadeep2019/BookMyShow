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
        public Task<IEnumerable<CustomerDTO>> GetAll()
        {
            var databaseContext = new PetaPoco.Database("BookMyShow", "");
            var customerdto =  databaseContext.Query<CustomerDTO>("Select * From Customer").ToList();
            return Task.FromResult(_mapper.Map<IEnumerable<CustomerDTO>>(customerdto));    
        }

        public CustomerDTO GetCustomer(int id)
        {
            var databaseContext = new PetaPoco.Database("BookMyShow", "");
            var customerDeatils = databaseContext.Single<CustomerDTO>("SELECT * FROM Customer WHERE Id = @0", id);
            return customerDeatils;
        }

        public Customer Insert(Customer customer)
        {
            var databaseContext = new PetaPoco.Database("BookMyShow", "");
            databaseContext.Insert(customer);
            return customer;
        }
    }
}
