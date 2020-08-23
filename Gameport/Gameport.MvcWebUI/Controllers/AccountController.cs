using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gameport.MvcWebUI.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult SingIn()
        {
            return View();
        }
        public ActionResult SingUp()
        {
            return View();
        }
    }
}