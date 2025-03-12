using Microsoft.EntityFrameworkCore;

namespace Mission10_Takamura.Data
{
    public class BowlingDbContext : DbContext
    {
        public BowlingDbContext(DbContextOptions<BowlingDbContext> options) : base(options) {

        }
        public DbSet<BowlingLeague> Bowlers { get; set; }
        public DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BowlingLeague>()
                .HasOne(b => b.Team)
                .WithMany()  // No need for a collection in Team unless you want it
                .HasForeignKey(b => b.TeamID)
                .OnDelete(DeleteBehavior.Restrict); // Prevents cascading deletion
        }
    }
}
