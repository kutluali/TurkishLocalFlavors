﻿using Microsoft.AspNetCore.Mvc;
namespace TurkishLocalFlavorsUI.ViewComponents.LayoutComponents
{
	public class _LayoutNavbarComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
