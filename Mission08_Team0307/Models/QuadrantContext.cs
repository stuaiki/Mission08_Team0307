using Microsoft.EntityFrameworkCore;

namespace Mission08_Team0307.Models
{
    public class QuadrantContext: DbContext
    {
        public QuadrantContext(DbContextOptions<QuadrantContext> options) : base(options)  //constoller
        { 
        }

        public DbSet<TaskEntry> Tasks { get; set; }
    }
}
