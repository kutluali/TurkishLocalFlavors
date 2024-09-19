using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TurkishLocalFlavors.Entity.Entities;
using TurkishLocalFlavorsUI.Dtos.IdentityDtos;

namespace TurkishLocalFlavorsUI.Controllers
{
	[AllowAnonymous]
	public class LoginController : Controller
	{
		private readonly SignInManager<AppUser> _signInManager;

		public LoginController(SignInManager<AppUser> signInManager)
		{
			_signInManager = signInManager;
		}

		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Index(LoginDto loginDto)
		{
			var result= await _signInManager.PasswordSignInAsync(loginDto.Username,loginDto.Password, false,false);
			if (result.Succeeded)
			{
				return RedirectToAction("Index", "Admin");
			}
			return View();
		}

		public async Task<IActionResult> LogOut()
		{
			await _signInManager.SignOutAsync();
			return RedirectToAction("Index", "Login");
		}
	}
}
