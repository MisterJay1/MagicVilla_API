using MagicVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {            
        }

        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Name = "Royal Villa",
                    Details = "Set on a beautiful street with an amazing view to a sunset.",
                    ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1280x900/295090917.jpg?k=d17621b71b0eaa0c7a37d8d8d02d33896cef75145f61e7d96d296d88375a7d39&o=&hp=1",
                    Occupancy = 5,
                    Rate = 200,
                    Sqft = 550,
                    Amenity = "",
                    DateCreated = DateTime.Now
                },
                new Villa()
                {
                    Id = 2,
                    Name = "Green Villa",
                    Details = "Set on a green street.",
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSCwKconmBwaneB1wv1YNzCNnq9u013ul1l8FW07Y9XEY5WTIAS_75cb_vbz4FyU2nyzCM&usqp=CAU",
                    Occupancy = 7,
                    Rate = 300,
                    Sqft = 750,
                    Amenity = "",
                    DateCreated = DateTime.Now
                },
                new Villa()
                {
                    Id = 3,
                    Name = "Blue Villa",
                    Details = "Set on a blue street.",
                    ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/301483778.jpg?k=b1f449beb857de98e8287c34956b672956926c2d03ac185ff8d9a348622c157a&o=&hp=1",
                    Occupancy = 9,
                    Rate = 500,
                    Sqft = 950,
                    Amenity = "",
                    DateCreated = DateTime.Now
                },
                new Villa()
                {
                    Id = 4,
                    Name = "Red Villa",
                    Details = "Set on a red street.",
                    ImageUrl = "https://image.architonic.com/prj2-3/20714433/swissfineline-reference--villalakezurich-pic01-villa-zurichsee-1-arcit18.jpg",
                    Occupancy = 11,
                    Rate = 700,
                    Sqft = 1150,
                    Amenity = "",
                    DateCreated = DateTime.Now
                },
                new Villa()
                {
                    Id = 5,
                    Name = "Orange Villa",
                    Details = "Set on an orange street.",
                    ImageUrl = "https://www.myistria.com/UserDocsImages/app/objekti/1384/slika_hd/06052022024444_Villa-in-Pula-Villa%20Old%20Olive%20I%20-%20n3.jpg?preset=carousel-1-webp",
                    Occupancy = 31,
                    Rate = 900,
                    Sqft = 1350,
                    Amenity = "",
                    DateCreated = DateTime.Now
                }
                );
        }
    }
}
