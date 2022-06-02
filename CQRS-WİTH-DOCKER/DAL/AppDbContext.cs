using CQRS_WİTH_DOCKER.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CQRS_WİTH_DOCKER.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasData(
                new User { Id = 100, Name = "Ramal Abaszade", Age = 20 },
                new User { Id = 101, Name = "Rasul Quliyev", Age = 20 },
                new User { Id = 103, Name = "Seymur Umudov", Age = 20 }
            );
        }
    }
}
