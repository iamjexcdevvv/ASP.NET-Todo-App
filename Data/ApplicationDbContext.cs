using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<Todo> TodoEntries { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.ConfigureWarnings(warnings =>
                warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Todo>().HasData(
                new Todo {
                    Id = 1,
                    Taskname = "Wash plate",
                    DateCreated = DateTime.Now
                },
                new Todo
                {
                    Id = 2,
                    Taskname = "Clean room",
                    DateCreated = DateTime.Now
                },
                new Todo
                {
                    Id = 3,
                    Taskname = "Do home work",
                    DateCreated = DateTime.Now
                }
            );
        }
    }
}
