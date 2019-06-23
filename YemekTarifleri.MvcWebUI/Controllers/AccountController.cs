using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using YemekTarifleri.Business.Abstract;
using YemekTarifleri.Core.CrossCuttingConcerns.Security.Web;
using YemekTarifleri.Entities.Concrete;
using YemekTarifleri.MvcWebUI.Models;

namespace YemekTarifleri.MvcWebUI.Controllers
{
    public class AccountController : Controller
    {
        private IUserService _userService;
        private IUserRoleService _userRoleService;

        public AccountController(IUserService userService,IUserRoleService userRoleService)
        {
            _userService = userService;
            _userRoleService = userRoleService;
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

        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(User registerUser)
        {
            _userService.Add(registerUser);
            var userRole = _userRoleService.Get(x=>x.Role.Name.Equals("User"));
            _userRoleService.Add(new UserRole {UserId = registerUser.Id, RoleId = userRole.RoleId});

            return RedirectToAction("Login");
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }


    }
}