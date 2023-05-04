using Microsoft.EntityFrameworkCore;

namespace Playtopia.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 
            
        }
    }
}
