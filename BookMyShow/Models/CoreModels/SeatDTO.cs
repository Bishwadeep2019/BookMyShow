namespace BookMyShow.Models.CoreModels
{
    public class SeatDTO
    {
       public int Id { get; set; }
       public int SeatId { get; set; }
       public int HallId { get; set; }
       public bool IsDeleted { get; set; }
       public DateTime? DateDeleted { get; set; }
    }
}
