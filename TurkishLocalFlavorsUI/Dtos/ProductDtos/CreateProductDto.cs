using System.ComponentModel.DataAnnotations;

namespace TurkishLocalFlavorsUI.Dtos.ProductDtos
{
    public class CreateProductDto
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public bool ProductStatus { get; set; }

        [Required(ErrorMessage = "Lütfen bir kategori seçiniz.")]
        public int CategoryID { get; set; }
    }
}
