using System.Threading.Tasks;
using netcore_e2e_app.Models;

namespace netcore_e2e_app.Persistence
{
    public interface IVehicleRepository
    {
         Task<Vehicle> GetVehicle(int id, bool includeRelated = true);
         void Add(Vehicle vehicle);
         void Remove(Vehicle vehicle);
    }
}