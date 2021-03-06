using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using netcore_e2e_app.Core;
using netcore_e2e_app.Models;

namespace netcore_e2e_app.Persistence
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly NetcoreE2eAppDbContext context;
        public VehicleRepository(NetcoreE2eAppDbContext context)
        {
            this.context = context;
        }

        public async Task<Vehicle> GetVehicle(int id, bool inlcudeRelated = true)
        {
            if (!inlcudeRelated)
                return await context.Vehicles.FindAsync(id);

            return await context.Vehicles
                .Include(v => v.Features)
                    .ThenInclude(vf => vf.Feature)
                .Include(v => v.Model)
                    .ThenInclude(m => m.Make)
                .SingleOrDefaultAsync(v => v.Id == id);
        }

        public void Add(Vehicle vehicle)
        {
            context.Vehicles.Add(vehicle);
        }

        public void Remove(Vehicle vehicle)
        {
            context.Vehicles.Remove(vehicle);
        }
    }
}