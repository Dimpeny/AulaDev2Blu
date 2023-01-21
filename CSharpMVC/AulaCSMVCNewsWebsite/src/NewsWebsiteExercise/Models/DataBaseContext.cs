using Microsoft.EntityFrameworkCore;
using NewsWebsiteExercise.Models.Entities;

namespace NewsWebsiteExercise.Models
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<News>()
                .HasOne(n => n.Category)
                .WithMany(c => c.News)
                .HasForeignKey(n => n.CategoryId);

            modelBuilder.Entity<Category>()
                .HasData(
                new { Id = 1, Name = "Pets" },
                new { Id = 2, Name = "Wildlife"},
                new { Id = 3, Name = "Culinary"}
                );

            modelBuilder.Entity<News>()
                .HasData(
                new { Id = 1, CategoryId = 1, Title = "Sejt has the moves!", Description = "Local wolf lady Sejt was found this morning doing the amogus twerk at park, gathering a large crowd of observers." },
                new { Id = 2, CategoryId = 1, Title = "Cats, should you trust them?", Description = "According to local cat expert Riche Shinta \"Cats are the most trustworthy animals of all time, and they definitely deserve a bit of salami every now and then, as a treat.\"" },
                new { Id = 3, CategoryId = 1, Title = "Why you should forfeit all mortal posessions to Seth", Description = "He's a good boy. That's it, that's the whole article, everything past riodoche migration will just have placeholder Lorem Ipsum text." },
                new { Id = 4, CategoryId = 2, Title = "Riodoche migration going smoothly.", Description = "Early this Monday, the local Riodoche population has begun their yearly migration up the mountain stream, where thousands of Famiries will form Staccs and Triamgles while vibin' in the tall grass." },
                new { Id = 5, CategoryId = 2, Title = "Tribal rabbits? Everything you need to know!", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque imperdiet auctor erat, id varius ipsum. Phasellus eget augue vestibulum, rutrum turpis eu, tempor mauris. Etiam commodo ligula sit amet mauris scelerisque efficitur. Aenean sit amet lobortis lacus, vitae placerat erat. Aliquam erat volutpat. Etiam luctus, massa ac bibendum eleifend, odio elit mollis purus, et blandit dui nulla quis ex. Nunc quis luctus velit. Pellentesque varius sollicitudin magna, nec fermentum felis vehicula sed. Sed cursus magna vitae augue feugiat, a ultrices enim varius. Proin tempus felis ut pulvinar viverra. Nulla vestibulum nibh in mauris imperdiet varius. Fusce imperdiet viverra libero id malesuada. Morbi pellentesque cursus efficitur. Sed fermentum sagittis mauris. Nulla laoreet ligula ut varius tempor." },
                new { Id = 6, CategoryId = 2, Title = "Woman falls in love with giant monkey.", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque imperdiet auctor erat, id varius ipsum. Phasellus eget augue vestibulum, rutrum turpis eu, tempor mauris. Etiam commodo ligula sit amet mauris scelerisque efficitur. Aenean sit amet lobortis lacus, vitae placerat erat. Aliquam erat volutpat. Etiam luctus, massa ac bibendum eleifend, odio elit mollis purus, et blandit dui nulla quis ex. Nunc quis luctus velit. Pellentesque varius sollicitudin magna, nec fermentum felis vehicula sed. Sed cursus magna vitae augue feugiat, a ultrices enim varius. Proin tempus felis ut pulvinar viverra. Nulla vestibulum nibh in mauris imperdiet varius. Fusce imperdiet viverra libero id malesuada. Morbi pellentesque cursus efficitur. Sed fermentum sagittis mauris. Nulla laoreet ligula ut varius tempor." },
                new { Id = 7, CategoryId = 3, Title = "Bug lady reveals secret to her family restaurant's delicious stews", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque imperdiet auctor erat, id varius ipsum. Phasellus eget augue vestibulum, rutrum turpis eu, tempor mauris. Etiam commodo ligula sit amet mauris scelerisque efficitur. Aenean sit amet lobortis lacus, vitae placerat erat. Aliquam erat volutpat. Etiam luctus, massa ac bibendum eleifend, odio elit mollis purus, et blandit dui nulla quis ex. Nunc quis luctus velit. Pellentesque varius sollicitudin magna, nec fermentum felis vehicula sed. Sed cursus magna vitae augue feugiat, a ultrices enim varius. Proin tempus felis ut pulvinar viverra. Nulla vestibulum nibh in mauris imperdiet varius. Fusce imperdiet viverra libero id malesuada. Morbi pellentesque cursus efficitur. Sed fermentum sagittis mauris. Nulla laoreet ligula ut varius tempor." },
                new { Id = 8, CategoryId = 3, Title = "Hyper realistic fitness cake shocks party goers", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque imperdiet auctor erat, id varius ipsum. Phasellus eget augue vestibulum, rutrum turpis eu, tempor mauris. Etiam commodo ligula sit amet mauris scelerisque efficitur. Aenean sit amet lobortis lacus, vitae placerat erat. Aliquam erat volutpat. Etiam luctus, massa ac bibendum eleifend, odio elit mollis purus, et blandit dui nulla quis ex. Nunc quis luctus velit. Pellentesque varius sollicitudin magna, nec fermentum felis vehicula sed. Sed cursus magna vitae augue feugiat, a ultrices enim varius. Proin tempus felis ut pulvinar viverra. Nulla vestibulum nibh in mauris imperdiet varius. Fusce imperdiet viverra libero id malesuada. Morbi pellentesque cursus efficitur. Sed fermentum sagittis mauris. Nulla laoreet ligula ut varius tempor." },
                new { Id = 9, CategoryId = 3, Title = "Bugsnax and how to avoid them", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque imperdiet auctor erat, id varius ipsum. Phasellus eget augue vestibulum, rutrum turpis eu, tempor mauris. Etiam commodo ligula sit amet mauris scelerisque efficitur. Aenean sit amet lobortis lacus, vitae placerat erat. Aliquam erat volutpat. Etiam luctus, massa ac bibendum eleifend, odio elit mollis purus, et blandit dui nulla quis ex. Nunc quis luctus velit. Pellentesque varius sollicitudin magna, nec fermentum felis vehicula sed. Sed cursus magna vitae augue feugiat, a ultrices enim varius. Proin tempus felis ut pulvinar viverra. Nulla vestibulum nibh in mauris imperdiet varius. Fusce imperdiet viverra libero id malesuada. Morbi pellentesque cursus efficitur. Sed fermentum sagittis mauris. Nulla laoreet ligula ut varius tempor." }
                );
        }

        #region DBSets
        public DbSet<Category> Category { get; set; }
        public DbSet<News> News { get; set; }
        #endregion
    }
}
