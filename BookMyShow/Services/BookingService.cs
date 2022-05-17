using BookMyShow.DataModels;
using BookMyShow.Interface;
using BookMyShow.Models.CoreModels;

namespace BookMyShow.Services
{
    public class BookingService : IBookingService
    {
        private readonly AutoMapper.IMapper _mapper;
        public BookingService(AutoMapper.IMapper mapper)
        {
            _mapper = mapper;
        }

        //public Task<IEnumerable<BookingDTO>> CancelBooking(int id)
        //{
        //    var databaseContent = new PetaPoco.Database("BookMyShow", "");
        //    var bookingData  = databaseContent.Single<BookingDTO>("SELECT * FROM Customer WHERE Id = @0", id);
        //    bookingData.IsDeleted = true;
        //    databaseContent.Update(bookingData);
        //    return GetAll();
        //}

        public Task<IEnumerable<BookingDTO>> GetAll()
        {
            var databaseContent = new PetaPoco.Database("Server=DEAD-INSIDE;Database=BookMyShow;Trusted_Connection=True;", "System.Data.SqlClient");
            var bookingdto= databaseContent.Query<Booking>("SELECT * FROM Booking").ToList();
            return Task.FromResult(_mapper.Map<IEnumerable<BookingDTO>>(bookingdto));
        }

        public BookingDTO GetBookingById(int id)
        {
            var databaseContent = new PetaPoco.Database("Server=DEAD-INSIDE;Database=BookMyShow;Trusted_Connection=True;", "System.Data.SqlClient");
            var bookingDetail = databaseContent.Single<BookingDTO>("SELECT * FROM Booking WHERE Id = @0", id);
            return bookingDetail;
        }

        public Booking Insert(Booking booking)
        {
            var databaseContent = new PetaPoco.Database("Server=DEAD-INSIDE;Database=BookMyShow;Trusted_Connection=True;", "System.Data.SqlClient");
            databaseContent.Insert(booking);
            return booking;
        }
    }
}
