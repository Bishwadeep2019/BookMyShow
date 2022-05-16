namespace BookMyShow.Models.CoreModels
{
    public class CustomerDTO
    {
		public int Id { get; set; }
		public string CustomerName { get; set; }
		public string Email { get; set; }
		public string PhoneNumber { get; set; }
		public int CityId { get; set; }
		public bool IsDeleted { get; set; }
		public DateTime? DayDeleted { get; set; }
	}
}
