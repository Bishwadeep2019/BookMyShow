namespace BookMyShow.Models.CoreModels
{
    public class TheaterDTO
    {
        public int Id { get; set; }
        public string TheaterName { get; set; }
        public int TotalHall { get; set; }
        public bool IsDeleted { get; set; }
        public int CityId { get; set; }
        public DateTime? DayDeleted { get; set; }
    }
}
