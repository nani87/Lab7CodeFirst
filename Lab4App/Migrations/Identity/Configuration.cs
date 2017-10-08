namespace Lab4App.Migrations.Identity
{
    using Lab4App.Models.Lab4;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Lab4App.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\Identity";
        }

        protected override void Seed(Lab4App.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Provinces.AddOrUpdate(t => t.ProvinceName, getProvinces().ToArray());
            context.SaveChanges();

            context.Cities.AddOrUpdate(c => c.CityName, getCities(context).ToArray());

        }

        private List<City> getCities(Lab4App.Models.ApplicationDbContext context)
        {
            List<City> cities = new List<City>()
            {
                new City() {CityName="Victoria",  Population=84000,
                ProvinceCode = "BC"
                },
                 new City() { CityName="Vancouver",  Population=650000,
                ProvinceCode = "BC"
                },
                  new City() { CityName="New Westmister",  Population=71000,
                ProvinceCode = "BC"
                },
                 new City() { CityName="Saskatoon",  Population=250000,
                ProvinceCode = "SK"
                },
                 new City() {CityName="Regina",  Population=220000,
                ProvinceCode = "SK"
                },

                  new City() {CityName="Yokton",  Population=160000,
                ProvinceCode = "SK"
                },

                  new City() {CityName="Calgary",  Population=1200000,
                ProvinceCode = "AB"
                },
                 new City() {CityName="Edmonton",  Population=930000,
                ProvinceCode = "AB"
                },
                  new City() {CityName="Red Deer",  Population=100000,
                ProvinceCode = "AB"
                },

                  new City() {CityId=7, CityName="Toronto",  Population=2800000,
                ProvinceCode = "ON"
                },
                 new City() {CityId=8, CityName="Ottawa",  Population=950000,
                ProvinceCode = "ON"
                },
                   new City() {CityId=7, CityName="Hamilton",  Population=550000,
                ProvinceCode = "ON"
                }



            };
            return cities;
        }

        private List<Province> getProvinces()
        {
            List<Province> provinces = new List<Province>()
            {
                new Province() { ProvinceCode = "BC", ProvinceName = "Britsh Columbia"},
                new Province() { ProvinceCode = "ON", ProvinceName = "Ontario"},
                new Province() { ProvinceCode = "AB", ProvinceName = "Alberta"},
                new Province() { ProvinceCode = "SK", ProvinceName = "Saskatchewan"},

            };
            return provinces;
        }
    }
}
