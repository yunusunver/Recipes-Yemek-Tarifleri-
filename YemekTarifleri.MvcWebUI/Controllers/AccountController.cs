using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YemekTarifleri.Business.Abstract;
using YemekTarifleri.Core.CrossCuttingConcerns.Security.Web;
using YemekTarifleri.MvcWebUI.Models;

namespace YemekTarifleri.MvcWebUI.Controllers
{
    public class AccountController : Controller
    {
        private IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login(LoginViewModel loginUser)
        {
            var user = _userService.GetByUserNameAndPassword(loginUser.UserName, loginUser.Password);
            if (user != null)
            {
                AuthenticationHelper.CreateAuthCookie(
                    new Guid(),
                    user.UserName,
                    user.Email,
                    DateTime.Now.AddDays(15),
                    _userService.GetUserRoles(user).Select(x => x.RoleName).ToArray(),
                    loginUser.RememberMe,
                    user.FirstName,
                    user.LastName
                );
                return RedirectToAction("Index","Home");
            }

            return RedirectToAction("Login");
        }


    }
}