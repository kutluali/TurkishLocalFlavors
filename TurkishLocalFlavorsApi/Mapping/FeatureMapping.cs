using AutoMapper;
using TurkishLocalFlavors.Dto.FeatureDto;
using TurkishLocalFlavors.Entity.Entities;

namespace TurkishLocalFlavorsApi.Mapping
{
    public class FeatureMapping : Profile
    {
        public FeatureMapping()
        {
            CreateMap<Feature, ResultFeatureDto>().ReverseMap();
            CreateMap<Feature, CreateFeatureDto>().ReverseMap();
            CreateMap<Feature, UpdateFeatureDto>().ReverseMap();
            CreateMap<Feature, GetFeatureDto>().ReverseMap();
        }
    }
}
