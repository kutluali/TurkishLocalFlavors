using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using TurkishLocalFlavorsUI.Dtos.BookingDtos;

namespace TurkishLocalFlavorsUI.ViewComponents.HomeComponents
{
    public class _HomeBookaTableComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
