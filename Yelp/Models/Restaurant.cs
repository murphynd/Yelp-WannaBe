using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Yelp.Models
{
  public class Restaurant
  {
    public Restaurant()
    {
      this.Reviews = new HashSet<Review>();
    }
    public int RestaurantId { get; set; }
    public string Description { get; set; }
    public string Image { get; set; }
    public string Address { get; set; }

    public int CuisineId { get; set; }
    public virtual Cuisine Cuisine { get; set; }
    public virtual ICollection<Review> Reviews { get; set; }

  }
}
