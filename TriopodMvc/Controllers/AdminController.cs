using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TriopodMvc.Models;

namespace TriopodMvc.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View(new Admin());
        }

        [HttpPost]
        public ActionResult Login(Admin admin)
        {
            using (var db = new DataContext())
            {
                bool isValid = db.Admins.Any(x => x.Username == admin.Username && x.Password == admin.Password);
                if (isValid)
                {
                    FormsAuthentication.SetAuthCookie(admin.Username, false);
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Invalid");
                return View();
            }
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}