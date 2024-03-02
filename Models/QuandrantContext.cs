using Microsoft.EntityFrameworkCore;

namespace Mission_8.Models
{
    public class QuandrantContext : DbContext 
    {
        public QuandrantContext(DbContextOptions<QuandrantContext> options) : base (options)
        {
        }

        public DbSet<TaskModel> Tasks { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Quadrant> Quadrants { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(

                new Category { CategoryId=1, CategoryName="Home"},
                new Category { CategoryId=2, CategoryName="School"},
                new Category { CategoryId=3, CategoryName="Work"},
                new Category { CategoryId=4, CategoryName="Church"}

            );
        }
    }
}
