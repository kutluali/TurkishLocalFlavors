namespace TurkishLocalFlavorsUI.Dtos.SocialMediaDtos
{
    public class GetSocialMediaDto
    {
        public int SocialMediaID { get; set; }
        private string title;  // Özel alan
        public string Title
        {
            get => title;  // Getter
            set => title = value?.ToLower();  // Setter: Değeri küçük harfe dönüştür
        }
        public string Url { get; set; }
    }
}
