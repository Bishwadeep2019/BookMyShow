using BookMyShow.DataModels;
using BookMyShow.Interface;
using BookMyShow.Models.CoreModels;

namespace BookMyShow.Services
{
    public class CustomerSeatService: ICustomerSeatService
    {
        private readonly AutoMapper.IMapper _mapper;
        public CustomerSeatService(AutoMapper.IMapper mapper)
        {
            _mapper = mapper;
        }

        public Task<IEnumerable<CustomerSeatDTO>> GetAll()
        {
            var databaseContext = new PetaPoco.Database("Server=DEAD-INSIDE;Database=BookMyShow;Trusted_Connection=True;", "System.Data.SqlClient");
            var customerseatdto = databaseContext.Query<Booking>("SELECT * FROM CustomerSeat").ToList();
            return Task.FromResult(_mapper.Map<IEnumerable<CustomerSeatDTO>>(customerseatdto));
        }

        public CustomerSeatDTO GetById(int id)
        {
            var databaseContext = new PetaPoco.Database("Server=DEAD-INSIDE;Database=BookMyShow;Trusted_Connection=True;", "System.Data.SqlClient");
            var customerSeatDetails = databaseContext.Single<CustomerSeatDTO>("SELECT * FROM CustomerSeat WHERE Id = @0", id);
            return customerSeatDetails;
        }

        public CustomerSeat Insert(CustomerSeat customerSeat)
        {
            var databaseContext = new PetaPoco.Database("Server=DEAD-INSIDE;Database=BookMyShow;Trusted_Connection=True;", "System.Data.SqlClient");
            databaseContext.Insert(customerSeat);
            return customerSeat;
        }
    }
}
