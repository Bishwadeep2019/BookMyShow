namespace BookMyShow.Models.CoreModels
{
    public class CustomerSeatDTO
    {
		public int Id { get; set; }
		public int Price { get; set; }
		public int TheaterSeatId { get; set; }
		public int BookingId { get; set; }
		public bool IsDeleted { get; set; }
		public DateTime? DayDeleted { get; set; }
	}
}
