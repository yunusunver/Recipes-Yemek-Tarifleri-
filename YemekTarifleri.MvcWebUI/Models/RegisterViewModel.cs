using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YemekTarifleri.MvcWebUI.Models
{
    public class RegisterViewModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}