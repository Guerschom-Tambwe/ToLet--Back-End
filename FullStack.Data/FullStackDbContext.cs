using FullStack.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FullStack.Data
{
    public class FullStackDbContext: DbContext
    {
        public FullStackDbContext(DbContextOptions<FullStackDbContext> options)
           : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Advert> Adverts { get; set; }


        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceItem> InvoiceItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Forenames = "Admin",
                    Surname = "User",
                    Email ="admin@test.com",
                    Password = "administration",
                    ConfirmPassword = "administration",
                    Role = "Admin"
                },
                new User
                {
                    Id = 2,
                    Forenames = "Anthony",
                    Surname = "Coder",
                    Email = "anthonyCoder@gmail.com",
                    Password = "administration",
                    ConfirmPassword = "administration",
                    Role = "User"
                }
                );

            modelBuilder.Entity<Advert>().HasData(
                new Advert
                {
                    AdvertId = 1,
                    Headline = "Very First Headline",
                    Province = "Western Cape",
                    City = "Belville",
                    AdvertDetails = "This is the very first advert",
                    Price = 12.98M,
                    UserId = 2,
                    AdvertStatus = "LIVE"
    }
                );

            modelBuilder.Entity<Province>().HasData(
                new Province
                {
                    ProvinceId = 1,
                    ProvinceName = "Western Cape",
                },
                new Province
                {
                    ProvinceId = 2,
                    ProvinceName = "Northern Cape"
                },
                new Province
                {
                    ProvinceId = 3,
                    ProvinceName = "North West"
                },
                new Province
                {
                    ProvinceId = 4,
                    ProvinceName = "Gauteng"
                },
                new Province
                {
                    ProvinceId = 5,
                    ProvinceName = "Free State"
                },
                new Province
                {
                    ProvinceId = 6,
                    ProvinceName = "Limpop"
                },
                new Province
                {
                    ProvinceId = 7,
                    ProvinceName = "Eastern Cape"
                },
                new Province
                {
                    ProvinceId = 8,
                    ProvinceName = "Kwazulu-Natal"
                },
                new Province
                {
                    ProvinceId = 9,
                    ProvinceName = "Mpumalangae"
                }
                );

            modelBuilder.Entity<City>().HasData(
                new City
                {
                    CityId = 1,
                    CityName = "Alice",
                    ProvinceId = 7,
                },
                new City
                {
                    CityId = 2,
                    CityName = "Port Elizabeth",
                    ProvinceId = 7,
                },
                new City
                {
                    CityId = 3,
                    CityName = "Graham's Town",
                    ProvinceId = 7,
                },
                new City
                {
                    CityId = 4,
                    CityName = "East London",
                    ProvinceId = 7,
                },


                new City
                {
                    CityId = 5,
                    CityName = "Parys",
                    ProvinceId = 5,
                },
                new City
                {
                    CityId = 6,
                    CityName = "Bloemfontein",
                    ProvinceId = 5,
                },
                new City
                {
                    CityId = 7,
                    CityName = "Virginia",
                    ProvinceId = 5,
                },
                new City
                {
                    CityId = 8,
                    CityName = "Welkom",
                    ProvinceId = 5,
                },


                new City
                {
                    CityId = 9,
                    CityName = "Rustenberg",
                    ProvinceId = 3,
                },
                new City
                {
                    CityId = 10,
                    CityName = "Mahikeng",
                    ProvinceId = 3,
                },
                new City
                {
                    CityId = 11,
                    CityName = "Klerksdorp",
                    ProvinceId = 3,
                },
                new City
                {
                    CityId = 12,
                    CityName = "Mmabatho",
                    ProvinceId = 3,
                },

                new City
                {
                    CityId = 13,
                    CityName = "Kimberly",
                    ProvinceId = 2,
                },
                 new City
                 {
                     CityId = 14,
                     CityName = "Kuruman",
                     ProvinceId = 2,
                 },
                 new City
                 {
                     CityId = 15,
                     CityName = "Port Nolloth",
                     ProvinceId = 2,
                 },

                new City
                {
                    CityId = 16,
                    CityName = "Boksburg",
                    ProvinceId = 4,
                },
                new City
                {
                    CityId = 17,
                    CityName = "Brakpan",
                    ProvinceId = 4,
                },
                new City
                {
                    CityId = 18,
                    CityName = "Carletonville",
                    ProvinceId = 4,
                },
                new City
                {
                    CityId = 19,
                    CityName = "Johannesburg",
                    ProvinceId = 4,
                },



                new City
                {
                    CityId = 20,
                    CityName = "Musina",
                    ProvinceId = 6,
                },
                new City
                {
                    CityId = 21,
                    CityName = "Polokwane",
                    ProvinceId = 6,
                },
                new City
                {
                    CityId = 22,
                    CityName = "Lebowakgomo",
                    ProvinceId = 6,
                },
                new City
                {
                    CityId = 23,
                    CityName = "Sibasa",
                    ProvinceId = 6,
                },
                new City
                {
                    CityId = 24,
                    CityName = "Phalaborwa",
                    ProvinceId = 6,
                },


                new City
                {
                    CityId = 25,
                    CityName = "Durban",
                    ProvinceId = 8,
                },
                new City
                {
                    CityId = 26,
                    CityName = "Pinetown",
                    ProvinceId = 8,
                },
                new City
                {
                    CityId = 27,
                    CityName = "Pietermaritzburg",
                    ProvinceId = 8,
                },
                new City
                {
                    CityId = 28,
                    CityName = "Umlazi",
                    ProvinceId = 8,
                },


                new City
                {
                    CityId = 29,
                    CityName = "Bellville",
                    ProvinceId = 1,
                },
                new City
                {
                    CityId = 30,
                    CityName = "Cape Town",
                    ProvinceId = 1,
                },
                new City
                {
                    CityId = 31,
                    CityName = "Paarl",
                    ProvinceId = 1,
                },
                new City
                {
                    CityId = 32,
                    CityName = "Simon's Town",
                    ProvinceId = 1,
                },


                new City
                {
                    CityId = 33,
                    CityName = "Nelspruit",
                    ProvinceId = 9,
                },
                new City
                {
                    CityId = 34,
                    CityName = "Secunda",
                    ProvinceId = 9,
                },
                 new City
                 {
                     CityId = 35,
                     CityName = "Emulahleni",
                     ProvinceId = 9,
                 }
            );
        }
        }
}
