﻿using BookMyShow.Models.CoreModels;
using BookMyShow.DataModels;
namespace BookMyShow.Interface
{
    public interface ITheaterService
    {
        Task<IEnumerable<TheaterDTO>> GetAll();
        TheaterDTO GetTheater(int id);
        Theater Insert(Theater theater);
        Task<IEnumerable<CityTheaterDTO>> GetAllCityTheater();
        Task<IEnumerable<CityTheaterDTO>> GetByName(string cityName, int movieId);
    }
}
