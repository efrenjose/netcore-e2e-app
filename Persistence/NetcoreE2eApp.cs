using Microsoft.EntityFrameworkCore;

namespace netcore_e2e_app.Persistence
{
    public class NetcoreE2eAppDbContext : DbContext
    {
        
        public NetcoreE2eAppDbContext(DbContextOptions<NetcoreE2eAppDbContext> options)
            : base(options)
        {
            
        }
    }
}