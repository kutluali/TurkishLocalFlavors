using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TurkishLocalFlavors.Entity.Entities;
using TurkishLocalFlavorsUI.Dtos.IdentityDtos;

namespace TurkishLocalFlavorsUI.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(RegisterDto registerDto)
        {
            var appUser = new AppUser()
            {
                Email=registerDto.Mail,
                UserName=registerDto.Username,
                Name=registerDto.Name,
                Surname=registerDto.Surname,
            };
            var result = await _userManager.CreateAsync(appUser, registerDto.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Login");
            }
            return View();
        }
    }
}
