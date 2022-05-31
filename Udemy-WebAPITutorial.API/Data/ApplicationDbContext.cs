using Microsoft.EntityFrameworkCore;

namespace Udemy_WebAPITutorial.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Jamaica",
                    ShortName = "JM"
                },
                new Country
                {
                    Id = 2,
                    Name = "Bahamas",
                    ShortName = "BS"
                },
                new Country
                {
                    Id = 3,
                    Name = "Greece",
                    ShortName = "GR"
                },
                new Country
                {
                    Id = 4,
                    Name = "Cyprus",
                    ShortName = "CY"
                }
            );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Metaksourgeio Luxury Suites",
                    Address = "Pelopos 5",
                    CountryId = 3,
                    Rating = 4.3
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Arcadia Magnificent Suites",
                    Address = "Vas. Sofias 13",
                    CountryId = 3,
                    Rating = 2.5
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Cypriot Supreme",
                    Address = "Pavlos Pavlou 32",
                    CountryId = 4,
                    Rating = 4.2
                },
                new Hotel
                {
                    Id = 4,
                    Name = "Sandals Resort and Spa",
                    Address = "Negril",
                    CountryId = 1,
                    Rating = 3.9
                },
                new Hotel
                {
                    Id = 5,
                    Name = "Comfort Suites",
                    Address = "George Town",
                    CountryId = 2,
                    Rating = 4.5
                }
            );
        }
    }
}
