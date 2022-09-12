using DotNetCore2.Core.Convertors;
using DotNetCore2.Core.DTOs;
using DotNetCore2.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore2.Controllers
{
    public class AccountController : Controller
    {
        private IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }
        [Route("Register")]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(RegisterViewModel register)
        {
            if (!ModelState.IsValid)
            {
                return View(register);
            }

            if (_userService.IsExistUserName(register.UserName))
            {
                ModelState.AddModelError("UserName","نام کاربری معتبر نمی باشد");
                return View(register);
            }

            if (_userService.IsExistUserName(FixedText.FixEmail(register.Email)))
            {
                ModelState.AddModelError("Email", "ایمیل معتبر نمی باشد");
                return View(register);
            }

            //TODO: Register User
            return View();
        }
    }
}
