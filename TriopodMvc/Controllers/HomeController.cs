using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TriopodMvc.Models;

namespace TriopodMvc.Controllers
{
    public class HomeController : Controller
    {
        private DataContext db = new DataContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Services()
        {
            return View();
        }

        public ActionResult ServicesInfo()
        {
            return View();
        }

        public ActionResult Product()
        {
            return View();
        }

        public ActionResult Contact()
        {
            Contact cn = new Contact();
            cn.DateTime = System.DateTime.Now;
            return View(cn);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Contact(Contact contact)
        {
            if (ModelState.IsValid)
            {
                db.Contacts.Add(contact);
                db.SaveChanges();
                return RedirectToAction("Contact");
            }

            return View(contact);
        }

        public ActionResult NewEntry()
        {
            Customer cus = new Customer();
            cus.DateTime = System.DateTime.Now;
            return View(cus);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NewEntry(Customer customer)
        {
            if(ModelState.IsValid)
            {
                db.Customers.Add(customer);
                db.SaveChanges();
                return RedirectToAction("Contact");
            }

            return View(customer);
        }
    }
}