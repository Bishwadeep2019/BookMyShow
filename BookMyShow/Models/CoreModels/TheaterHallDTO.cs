namespace BookMyShow.Models.CoreModels
{
    public class TheaterHallDTO
    {
		public int Id { get; set; }
		public int TotalSeats { get; set; }
		public int ShowID { get; set; }
		public int TheaterId { get; set; }
		public bool IsDeleted { get; set; }
		public DateTime? DayDeleted { get; set; }
	}
}
