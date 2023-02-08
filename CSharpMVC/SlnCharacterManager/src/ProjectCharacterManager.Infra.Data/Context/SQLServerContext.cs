using Microsoft.EntityFrameworkCore;
using ProjectCharacterManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCharacterManager.Infra.Data.Context
{
    public class SQLServerContext : DbContext
    {
        public SQLServerContext(DbContextOptions<SQLServerContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<World>()
                .HasData(
                    new { Id = 1, Name = "OBCM World", Description = "The world where only OBCM exists" },
                    new { Id = 2, Name = "Pink's dimension", Description = "A dreamscape where Pink exists, outside all realities" },
                    new { Id = 3, Name = "Perfeita Realidade", Description = "The world where no involuntary suffering exists" }
                );

        }
        #region DBSets<Tables>
        /*
        public DbSet<Category> Categories { get; set; }
        public DbSet<News> News { get; set; }
        */
        public DbSet<Character> Characters { get; set; }
        public DbSet<World> Worlds { get; set; }
        #endregion
    }
}
