using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YemekTarifleri.Core.CrossCuttingConcerns.Security.Web;

namespace YemekTarifleri.MvcWebUI.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public string Login()
        {
            AuthenticationHelper.CreateAuthCookie(new Guid(),"yunus","yunus@gmail.com",DateTime.Now.AddDays(15),new []{"Admin"},false,"yunus","ünver");
            return "Access denied.";
        }
    }
}