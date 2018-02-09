using AutoMapper;
using netcore_e2e_app.Models;
using netcore_e2e_app.Models.Resources;

namespace netcore_e2e_app.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Make, MakeResource>();
            CreateMap<Model, ModelResource>();
            CreateMap<Feature, FeatureResource>();
        }
    }
}