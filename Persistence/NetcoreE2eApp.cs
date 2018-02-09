using Microsoft.EntityFrameworkCore;
using netcore_e2e_app.Models;

namespace netcore_e2e_app.Persistence
{
    public class NetcoreE2eAppDbContext : DbContext
    {
        
        public NetcoreE2eAppDbContext(DbContextOptions<NetcoreE2eAppDbContext> options)
            : base(options)
        {
            
        }

        public DbSet<Make> Makes { get; set; }
        
    }
}