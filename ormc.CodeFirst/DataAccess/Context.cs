using Microsoft.EntityFrameworkCore;

namespace ormc.CodeFirst.DataAccess
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Models.CodeFirstDriver> Driver { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("cf");
            modelBuilder.Entity<Models.CodeFirstDriver>().ToTable("Driver");
        }
    }
}