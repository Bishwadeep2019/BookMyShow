using BookMyShow.Models.CoreModels;
using BookMyShow.DataModels;
using BookMyShow.Interface;

namespace BookMyShow.Services
{
    public class ShowService : IShowService
    {
        private readonly AutoMapper.IMapper _mapper;
        private PetaPocoDB _petPocoDB;
        public ShowService(AutoMapper.IMapper mapper, PetaPocoDB pb)
        {
            _mapper = mapper;
            this._petPocoDB = pb;
        }
        public Task<IEnumerable<ShowDTO>> GetAllShow()
        {
            var moviedto = this._petPocoDB.Query<Show>("SELECT * FROM Show").ToList();
            return Task.FromResult(_mapper.Map<IEnumerable<ShowDTO>>(moviedto));
        }

        public ShowDTO GetShowById(int id)
        {
            var showDetails = this._petPocoDB.Single<ShowDTO>("SELECT * FROM Show WHERE Id = @0", id);
            return showDetails;
        }

        public Show InsertShowDetails(Show show)
        {
            this._petPocoDB.Insert(show);
            return show;
        }

    }
}
