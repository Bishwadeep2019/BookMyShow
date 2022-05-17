using BookMyShow.Models.CoreModels;
using BookMyShow.DataModels;
using BookMyShow.Interface;

namespace BookMyShow.Services
{
    public class ShowService : IShowService
    {
        private readonly AutoMapper.IMapper _mapper;
        public ShowService(AutoMapper.IMapper mapper)
        {
            _mapper = mapper;
        }
        public Task<IEnumerable<ShowDTO>> GetAll()
        {
            var databaseContent = new PetaPoco.Database("Server=DEAD-INSIDE;Database=BookMyShow;Trusted_Connection=True;", "System.Data.SqlClient");
            var moviedto = databaseContent.Query<Show>("SELECT * FROM Show").ToList();
            return Task.FromResult(_mapper.Map<IEnumerable<ShowDTO>>(moviedto));
        }

        public ShowDTO GetShow(int id)
        {
            var databaseContent = new PetaPoco.Database("Server=DEAD-INSIDE;Database=BookMyShow;Trusted_Connection=True;", "System.Data.SqlClient");
            var showDetails = databaseContent.Single<ShowDTO>("SELECT * FROM Show WHERE Id = @0", id);
            return showDetails;
        }

        public Show Insert(Show show)
        {
            var databaseContent = new PetaPoco.Database("Server=DEAD-INSIDE;Database=BookMyShow;Trusted_Connection=True;", "System.Data.SqlClient");
            databaseContent.Insert(show);
            return show;
        }
    }
}
