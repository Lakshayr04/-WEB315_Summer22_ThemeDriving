using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _WEB315_Summer22_ThemeDriving.Models;

    public class ThemeDrivingContext : DbContext
    {
        public ThemeDrivingContext (DbContextOptions<ThemeDrivingContext> options)
            : base(options)
        {
        }

        public DbSet<_WEB315_Summer22_ThemeDriving.Models.ThemeDriving> ThemeDriving { get; set; }
    }
