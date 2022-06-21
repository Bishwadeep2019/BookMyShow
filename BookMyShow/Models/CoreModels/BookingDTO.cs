namespace BookMyShow.Models.CoreModels
{
    public class BookingDTO
    {
		public int Id { get; set; }
		public int RequiredSeats { get; set; }
		//selected seats
		public DateTime BookingDate { get; set; }
		public int CustomerId { get; set; }
		public int ShowId { get; set; }
		public bool IsDeleted { get; set; }
		public DateTime? DayDeleted { get; set; }
	}
}
