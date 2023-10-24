using Microsoft.EntityFrameworkCore;

namespace webapiproject.Model
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options) { }
        public DbSet<Leagues> Leaguess{ get; set; }
        public DbSet<Managers> Managerss { get; set; }
        public DbSet<Players> Playerss { get; set; }
        public DbSet<Teams> Teamss { get; set; }
    }
}
