namespace Yelp.Models
{
  public class Review
  {
    public int ReviewId { get; set; }
    public string Description { get; set; }
    public string UserName { get; set; }
    public string UserImage { get; set; }
    public int RestaurantId { get; set; }
    public virtual Restaurant Restaurant { get; set; }
  }
}