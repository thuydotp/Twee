using Microsoft.EntityFrameworkCore;

namespace Twee.Api.Models
{
    public class TweeContext : DbContext
    {
        public TweeContext(DbContextOptions<TweeContext> options)
            : base(options)
        { }

        public DbSet<Post> Posts { get; set; }
    }
}
