using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using netcore_e2e_app.Models;

namespace netcore_e2e_app.Persistence
{
    public class VehicleRepository
    {
        private readonly NetcoreE2eAppDbContext context;
        public VehicleRepository(NetcoreE2eAppDbContext context)
        {
            this.context = context;
        }

        public async Task<Vehicle> GetVehicle(int id)
        {

            return await context.Vehicles
                .Include(v => v.Features)
                    .ThenInclude(vf => vf.Feature)
                .Include(v => v.Model)
                    .ThenInclude(m => m.Make)
                .SingleOrDefaultAsync(v => v.Id == id);
        }
    }
}