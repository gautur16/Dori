using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoriVLN.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult NewUser()
        {
            //TODO: implement
            return View();
        }

        public ActionResult ResetPassword()
        {
            //TODO: implement
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
    }
}