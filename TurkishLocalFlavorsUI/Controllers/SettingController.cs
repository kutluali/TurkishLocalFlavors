using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TurkishLocalFlavors.Entity.Entities;
using TurkishLocalFlavorsUI.Dtos.IdentityDtos;

namespace TurkishLocalFlavorsUI.Controllers
{
    public class SettingController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public SettingController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditDto userEditDto=new UserEditDto();
            userEditDto.Surname = values.Surname;
            userEditDto.Name = values.Name;
            userEditDto.Mail = values.Email;
            userEditDto.Username = values.UserName;

            return View(userEditDto);
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserEditDto userEditDto)
        {
            if (userEditDto.Password==userEditDto.ConfirmPassword)
            {
                var user = await _userManager.FindByNameAsync(User.Identity.Name);
                user.Name = userEditDto.Name;
                user.Email = userEditDto.Mail;
                user.Surname=userEditDto.Surname;
                user.UserName = userEditDto.Username;
                user.PasswordHash=_userManager.PasswordHasher.HashPassword(user,userEditDto.Password);
                await _userManager.UpdateAsync(user);
                return RedirectToAction("Login");
            }
            return View(userEditDto);
        }

    }
}
