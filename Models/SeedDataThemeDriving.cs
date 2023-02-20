using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace _WEB315_Summer22_ThemeDriving.Models
{
    public static class SeedDataThemeDriving
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ThemeDrivingContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ThemeDrivingContext>>()))
            {
                // Look for any ThemeDriving.
                if (context.ThemeDriving.Any())
                {
                    return;   // DB has been seeded
                }

                context.ThemeDriving.AddRange(
                    new ThemeDriving
                    {
                        CarModel = "FZ",
                        BookingDate = DateTime.Parse("2023-2-19"),
                        Route = "University Avenue",
                        Price = 15.54M,
                        distance = "15 KM",
                        colour = "red",
                        Modelnumber = 2010
                    },

                    new ThemeDriving
                    {
                        CarModel = "Azure",
                        BookingDate = DateTime.Parse("2023-5-25"),
                        Route = "XYZ",
                        Price = 21.00M,
                        distance = "10 KM",
                        colour = "white",
                        Modelnumber = 2015
                    
                    },

                    new ThemeDriving
                    {
                        CarModel = "OD",
                        BookingDate = DateTime.Parse("2023-06-10"),
                        Route = "YYY",
                        Price = 20.90M,
                        distance = "12 KM",
                        colour = "grey",
                        Modelnumber = 2012
                    },

                    new ThemeDriving
                    {
                        CarModel = "BMW",
                        BookingDate = DateTime.Parse("2023-08-28"),
                        Route = "QAA",
                        Price = 19.44M,
                        distance = "19 KM",
                        colour = "orange",
                        Modelnumber = 2018
                    },

                    new ThemeDriving
                    {
                        CarModel = "A4",
                        BookingDate = DateTime.Parse("2023-03-20"),
                        Route = "ABC",
                        Price = 16.04M,
                        distance = "24 KM",
                        colour = "black",
                        Modelnumber = 2020
                    }
                );
                context.SaveChanges();
            }
        }
    }
}