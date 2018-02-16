using Microsoft.EntityFrameworkCore;
using netcore_e2e_app.Models;

namespace netcore_e2e_app.Persistence
{
    public class NetcoreE2eAppDbContext : DbContext
    {
        public DbSet<Make> Makes { get; set; }
        public DbSet<Feature> Features {get; set; }
        
        public NetcoreE2eAppDbContext(DbContextOptions<NetcoreE2eAppDbContext> options)
            : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<VehicleFeature>().HasKey(vf => 
              new { vf.VehicleId, vf.FeatureId });
        }
    }
}