using AutoMapper;
using BookMyShow.DataModels;
using BookMyShow.Models.CoreModels;

namespace BookMyShow.Models
{
    public class MapperClass:Profile
    {
        public MapperClass()
        {
            CreateMap<Customer, CustomerDTO>();
            CreateMap<Booking, BookingDTO>();
            CreateMap<City, CityDTO>();
            CreateMap<CustomerSeat, CustomerSeatDTO>();
            CreateMap<Movie, MovieDTO>();
            CreateMap<Show, ShowDTO>();
            CreateMap<Theater, TheaterDTO>();
            CreateMap<TheaterHall, TheaterHallDTO>();
            CreateMap<CityTheater, CityTheaterDTO>();

        }
    }
}
