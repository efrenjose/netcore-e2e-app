using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using netcore_e2e_app.Models;
using netcore_e2e_app.Models.Resources;

namespace netcore_e2e_app.Controllers
{
    [Route("/api/vehicles")]
    public class VehiclesController : Controller
    {
        private readonly IMapper mapper;

        public VehiclesController(IMapper mapper)
        {
            this.mapper = mapper;

        }
        [HttpPost]
        public IActionResult CreatVehicle([FromBody] VehicleResource vehicleResource)
        {
            var vehicle = mapper.Map<VehicleResource, Vehicle>(vehicleResource);
            return Ok(vehicle);
        }
    }
}