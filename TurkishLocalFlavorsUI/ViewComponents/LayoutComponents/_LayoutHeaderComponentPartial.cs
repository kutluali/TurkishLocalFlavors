﻿using Microsoft.AspNetCore.Mvc;

namespace TurkishLocalFlavorsUI.ViewComponents.LayoutComponents
{
	public class _LayoutHeaderComponentPartial :ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
