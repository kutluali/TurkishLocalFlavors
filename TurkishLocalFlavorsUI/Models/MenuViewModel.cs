using TurkishLocalFlavorsUI.Dtos.CategoryDtos;
using TurkishLocalFlavorsUI.Dtos.ProductDtos;

namespace TurkishLocalFlavorsUI.Models
{
    public class MenuViewModel
    {
        public List<ResultProductDto> ProductValues { get; set; }
        public List<ResultCategoryDto> CategoryValues { get; set; }
    }
}
