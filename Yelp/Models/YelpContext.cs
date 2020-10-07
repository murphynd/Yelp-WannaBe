using Microsoft.EntityFrameworkCore;

namespace Yelp.Models
{
  public class YelpContext : DbContext
  {
    public virtual DbSet<Cuisine> Cuisines { get; set; }
    public DbSet<Restaurant> Restaurants { get; set; }

    public YelpContext(DbContextOptions options) : base(options) { }
  }
}