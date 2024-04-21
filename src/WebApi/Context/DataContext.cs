using Microsoft.EntityFrameworkCore;
using WebApi.Domain.Models;
using WebApi.Mappings;

namespace WebApi.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CarMapping());
        }

        public DbSet<Car> Cars { get; set; }
    }
}
