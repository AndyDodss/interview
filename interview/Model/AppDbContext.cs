using Microsoft.EntityFrameworkCore;

namespace interview.Model
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        { }

        public DbSet<ReviewSession> reviewSessions { get; set; }    

    }
}
