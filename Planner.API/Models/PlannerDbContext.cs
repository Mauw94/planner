using Microsoft.EntityFrameworkCore;

namespace Planner.API.Models
{
    public class PlannerDbContext : DbContext
    {
        public PlannerDbContext() { }

        public PlannerDbContext(DbContextOptions<PlannerDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Event> Events { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
