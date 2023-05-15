using _5MinBackend.Entities;
using Microsoft.EntityFrameworkCore;

namespace _5MinBackend.Data
{
    public class MyDbContext : DbContext
    {
        public DbSet<WeatherForecast> WeatherForecasts { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }
    }
}