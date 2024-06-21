using API.Model;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class AppDbContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var users = new List<User>
            {
                new User
                {
                    Id = 1,
                    Username = "Alice"
                },
                new User
                {
                    Id = 2,
                    Username = "Bob"
                },
                new User
                {
                    Id = 3,
                    Username = "Jack"
                }

            };
            modelBuilder.Entity<User>().HasData(users);
        }

    }

}
