using AutoMapper;
using TurkishLocalFlavors.Dto.MenuTableDto;
using TurkishLocalFlavors.Entity.Entities;

namespace TurkishLocalFlavorsApi.Mapping
{
    public class MenuTableMapping : Profile
    {
        public MenuTableMapping()
        {
            CreateMap<MenuTable, ResultMenuTableDto>().ReverseMap();
            CreateMap<MenuTable, CreateMenuTableDto>().ReverseMap();
            CreateMap<MenuTable, GetMenuTableDto>().ReverseMap();
            CreateMap<MenuTable, UpdateMenuTableDto>().ReverseMap();
        }
    }
}
