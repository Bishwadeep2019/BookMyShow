﻿using BookMyShow.Models.CoreModels;
using BookMyShow.DataModels;
using BookMyShow.Interface;

namespace BookMyShow.Services
{
    public class TheaterHallService: ITheaterHallService
    {
        private readonly AutoMapper.IMapper _mapper;
        public TheaterHallService(AutoMapper.IMapper mapper)
        {
            _mapper = mapper;
        }

        public Task<IEnumerable<TheaterHallDTO>> GetAll()
        {
            var databaseContent = new PetaPoco.Database("BookMyShow", "");
            var theaterhalldto = databaseContent.Query<Show>("SELECT * FROM TheaterHall").ToList();
            return Task.FromResult(_mapper.Map<IEnumerable<TheaterHallDTO>>(theaterhalldto));
        }

        public TheaterHallDTO GetTheaterHall(int id)
        {
            var databaseContent = new PetaPoco.Database("BookMyShow", "");
            var theaterHallDetails = databaseContent.Single<TheaterHallDTO>("SELECT * FROM TheaterHall WHERE Id = @0", id);
            return theaterHallDetails;
        }

        public TheaterHall Insert(TheaterHall theaterHall)
        {
            var databaseContent = new PetaPoco.Database("BookMyShow", "");
            databaseContent.Insert(theaterHall);
            return theaterHall;
        }
    }
}