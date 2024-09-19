using TurkishLocalFlavorsUI.Dtos.ContactDtos;
using TurkishLocalFlavorsUI.Dtos.SocialMediaDtos;

namespace TurkishLocalFlavorsUI.Models
{
    public class FooterViewModel
    {
        public List<ResultContactDto> ContactValues { get; set; }
        public List<ResultSocialMediaDto> SocialMediaValues { get; set; }
    }
}
