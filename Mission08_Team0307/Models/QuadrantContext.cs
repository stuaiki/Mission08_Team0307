using Microsoft.EntityFrameworkCore;

namespace Mission08_Team0307.Models
{
    public class QuadrantContext: DbContext
    {
        public QuadrantContext(DbContextOptions<QuadrantContext> options) : base(options)  //constoller
        { 
        }

        public DbSet<TaskEntry> Tasks { get; set; }

        //Connect with Categories table
        public DbSet<Category> Categories { get; set; }

        //These are four values in categories table.
        protected override void OnModelCreating(ModelBuilder modelBuilder) //Seed data
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName= "Home"},
                new Category { CategoryId = 2, CategoryName = "School" },
                new Category { CategoryId = 3, CategoryName = "Work" },
                new Category { CategoryId = 4, CategoryName = "Church"}
                );
        }
    }
}
