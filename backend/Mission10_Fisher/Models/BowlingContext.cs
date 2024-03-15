using Microsoft.EntityFrameworkCore;

namespace Mission10_Fisher.Models
{
    public class BowlingContext : DbContext
    {
        public BowlingContext(DbContextOptions<BowlingContext> options) : base(options) { }

        public DbSet<Bowlers> Bowlers { get; set; }
        public DbSet<Teams> Teams{ get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bowlers>()
                .HasOne(b => b.Team)
                .WithMany()
                .HasForeignKey(b => b.TeamID);
        }
    }
}
