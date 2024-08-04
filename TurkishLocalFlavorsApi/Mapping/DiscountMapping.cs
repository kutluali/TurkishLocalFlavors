using AutoMapper;
using TurkishLocalFlavors.Dto.Discount;
using TurkishLocalFlavors.Dto.DiscountDto;
using TurkishLocalFlavors.Entity.Entities;

namespace TurkishLocalFlavorsApi.Mapping
{
    public class DiscountMapping : Profile
    {
        public DiscountMapping()
        {
            CreateMap<Discount, ResultDiscountDto>().ReverseMap();
            CreateMap<Discount, UpdateDiscountDto>().ReverseMap();
            CreateMap<Discount, CreateDiscountDto>().ReverseMap();
            CreateMap<Discount, GetDiscountDto>().ReverseMap();
        }
    }
}
