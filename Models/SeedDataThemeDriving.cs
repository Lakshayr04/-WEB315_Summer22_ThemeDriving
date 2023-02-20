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
                        Price = 1554,
                        distance = "15 KM",
                        colour = "red",
                        modelnumber = 2010
                    },

                    new ThemeDriving
                    {
                        CarModel = "Azure",
                        BookingDate = DateTime.Parse("2023-5-25"),
                        Route = "XYZ",
                        Price = 2100,
                        distance = "10 KM",
                        colour = "white",
                        modelnumber = 2015
                    
                    },

                    new ThemeDriving
                    {
                        CarModel = "OD",
                        BookingDate = DateTime.Parse("2023-06-10"),
                        Route = "YYY",
                        Price = 2090,
                        distance = "12 KM",
                        colour = "grey",
                        modelnumber = 2012
                    },

                    new ThemeDriving
                    {
                        CarModel = "BMW",
                        BookingDate = DateTime.Parse("2023-08-28"),
                        Route = "QAA",
                        Price = 1944,
                        distance = "19 KM",
                        colour = "orange",
                        modelnumber = 2018
                    },

                    new ThemeDriving
                    {
                        CarModel = "A4",
                        BookingDate = DateTime.Parse("2023-03-20"),
                        Route = "ABC",
                        Price = 1604,
                        distance = "24 KM",
                        colour = "black",
                        modelnumber = 2020
                    }
                );
                context.SaveChanges();
            }
        }
    }
}