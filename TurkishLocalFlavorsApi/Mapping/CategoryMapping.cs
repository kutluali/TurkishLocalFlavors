using AutoMapper;
using TurkishLocalFlavors.Dto.Category;
using TurkishLocalFlavors.Entity.Entities;

namespace TurkishLocalFlavorsApi.Mapping
{
    public class CategoryMapping:Profile
    {
        public CategoryMapping()
        {
            CreateMap<Category, ResultCategoryDto>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, GetCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();

        }
    }
}
