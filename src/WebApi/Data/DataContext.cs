﻿using Microsoft.EntityFrameworkCore;
using WebApi.Domain.Models;

namespace WebApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Car> Car { get; set; }
    }
}
