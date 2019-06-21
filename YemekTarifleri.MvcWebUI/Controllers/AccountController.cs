using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YemekTarifleri.Business.Abstract;
using YemekTarifleri.Core.CrossCuttingConcerns.Security.Web;

namespace YemekTarifleri.MvcWebUI.Controllers
{
    public class AccountController : Controller
    {
        private IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }


        // GET: Account
        public string Login(string userName,string password)
        {
            var user = _userService.GetByUserNameAndPassword(userName, password);
            if (user != null)
            {
                AuthenticationHelper.CreateAuthCookie(
                    new Guid(), 
                    user.UserName,
                    user.Email, 
                    DateTime.Now.AddDays(15), 
                    _userService.GetUserRoles(user).Select(x=>x.RoleName).ToArray(),
                    false, 
                    user.FirstName, 
                    user.LastName
                    );
                return "Access denied.";
            }

            return "Not Authenticated";
        }

        public ActionResult Login()
        {
            return View();
        }
    }
}