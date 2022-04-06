﻿using Library1.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class CarContext : DbContext
    {
        public CarContext(DbContextOptions<CarContext> options)
          : base(options)
        {
        }
        public DbSet<Car> Cars { get; set; }
    }
}
