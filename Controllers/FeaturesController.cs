using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using netcore_e2e_app.Models;
using netcore_e2e_app.Models.Resources;
using netcore_e2e_app.Persistence;

namespace netcore_e2e_app.Controllers
{
    [Route("api/[controller]")]
    public class FeaturesController : Controller
    {
        private readonly NetcoreE2eAppDbContext context;
        private readonly IMapper mapper;
        public FeaturesController(NetcoreE2eAppDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;
        }

        [HttpGet("/api/features")]
        public async Task<IEnumerable<FeatureResource>> GetFeatures()
        {
            var features = await context.Features.ToListAsync();

            return mapper.Map<List<Feature>, List<FeatureResource>>(features);
        }
    }
}