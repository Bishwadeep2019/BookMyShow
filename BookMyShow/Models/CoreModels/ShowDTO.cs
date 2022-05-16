namespace BookMyShow.Models.CoreModels
{
    public class ShowDTO
    {
		public int Id { get; set; }
		public string StartTime { get; set; }
		public string EndTime { get; set; }
		public DateTime ShowDate { get; set; }
		public int HallId { get; set; }
		public int MovieID { get; set; }
		public bool IsDeleted { get; set; }
		public DateTime? DayDeleted { get; set; }
	}
}
