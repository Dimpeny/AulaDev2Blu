using Devs2Blu.MovieAPI.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Devs2Blu.MovieAPI.Models.Data
{
    public class SQLServerContext : DbContext
    {
        public SQLServerContext(DbContextOptions<SQLServerContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>()
                .HasData(
                new
                {
                    Id = 1,
                    Title = "Riodoche zone",
                    Description = "Chill movie lenght documentary about the lives of Riodoches",
                    Rating = "Everyone"
                },
                new
                {
                    Id = 2,
                    Title = "Riodoche zone 2",
                    Description = "Chill movie lenght documentary about the lives of other Riodoches",
                    Rating = "Everyone"
                }
                );
        }

        public DbSet<Movie> Movies { get; set; }
    }
}
