using BookMyShow.DataModels;
using BookMyShow.Interface;
using BookMyShow.Models.CoreModels;

namespace BookMyShow.Services
{
    public class BookingService : IBookingService
    {
        private readonly AutoMapper.IMapper _mapper;
        private PetaPocoDB _petPocoDB;
        public BookingService(AutoMapper.IMapper mapper, PetaPocoDB pb)
        {
            _mapper = mapper;
            this._petPocoDB = pb;
        }

        public Task<IEnumerable<BookingDTO>> GetAllBooking()
        {
            var bookingdto= this._petPocoDB.Query<Booking>("Select * From Booking").ToList();
            return Task.FromResult(_mapper.Map<IEnumerable<BookingDTO>>(bookingdto));
        }

        public BookingDTO GetBookingById(int id)
        {            
            var bookingDetail = this._petPocoDB.Single<BookingDTO>("Select * From Booking WHERE Id = @0", id);
            return bookingDetail;
        }

        public Booking InsertBookingDetails(Booking booking)
        {
            this._petPocoDB.Insert(booking);
            return booking;
        }
    }
}
