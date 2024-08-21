using Microsoft.AspNetCore.Mvc;
namespace TurkishLocalFlavorsUI.ViewComponents.LayoutComponents
{
	public class _LayoutScriptComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
