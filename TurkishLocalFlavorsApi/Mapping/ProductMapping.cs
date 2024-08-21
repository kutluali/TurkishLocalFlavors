using AutoMapper;
using TurkishLocalFlavors.Dto.ProductDto;
using TurkishLocalFlavors.Entity.Entities;

namespace TurkishLocalFlavorsApi.Mapping
{
    public class ProductMapping : Profile
    {
        public ProductMapping()
        {
            CreateMap<Product, ResultProductDto>().ReverseMap();
            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
            CreateMap<Product, GetProductDto>().ReverseMap();
            CreateMap<Product, ResultProductWithCategory>().ReverseMap();
        }
    }
}
