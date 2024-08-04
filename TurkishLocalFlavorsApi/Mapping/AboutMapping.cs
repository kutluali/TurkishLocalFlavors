using AutoMapper;
using TurkishLocalFlavors.Dto.AboutDto;

namespace TurkishLocalFlavorsApi.Mapping
{
    public class AboutMapping : Profile
    {
        protected AboutMapping()
        {
            CreateMap<AboutMapping, ResultAboutDto>().ReverseMap();
            CreateMap<AboutMapping, CreateAboutDto>().ReverseMap();
            CreateMap<AboutMapping, GetAboutDto>().ReverseMap();
            CreateMap<AboutMapping, UpdateAboutDto>().ReverseMap();
        }
    }
}
