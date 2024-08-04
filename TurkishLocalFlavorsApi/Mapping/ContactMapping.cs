using AutoMapper;
using TurkishLocalFlavors.Dto.Contact;
using TurkishLocalFlavors.Entity.Entities;

namespace TurkishLocalFlavorsApi.Mapping
{
    public class ContactMapping :Profile
    {
        public ContactMapping()
        {
            CreateMap<Contact, ResultContactDto>().ReverseMap();
            CreateMap<Contact, CreateContactDto>().ReverseMap();
            CreateMap<Contact, UpdateContactDto>().ReverseMap();
            CreateMap<Contact, GetContactDto>().ReverseMap();
        }

    }
}
