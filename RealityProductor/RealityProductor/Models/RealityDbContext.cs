using System.Data.Entity;

namespace RealityProductor.Models
{
    public class RealityDbContext : DbContext
    {
        public DbSet<Competitor> Competitors { get; set; }
    }
}