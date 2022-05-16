namespace BookMyShow.Models.CoreModels
{
    public class MovieDTO
    {
		 public int Id { get; set; }
		 public string Title { get; set; }
		 public DateTime ReleaseDate { get; set; }
		 public string Language { get; set; }
		 public string MovieImageUrl { get; set; }
		 public string Genre { get; set; }
		 public string Duration { get; set; }
		 public bool IsDeleted { get; set; }
		 public DateTime? DayDeleted { get; set; }
	}
}
