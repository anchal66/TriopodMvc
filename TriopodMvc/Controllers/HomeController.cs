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
                ViewBag.Message = "Your Form Submitted";
                return RedirectToAction("Contact");
            }

            return View(contact);
        }

        public ActionResult ListContact()
        {
            var contacts = db.Contacts.ToList();
            return View(contacts);
        }

        public ActionResult Details(int id)
        {
            var emp = db.Contacts.Single(x => x.ContactId == id);
            return View(emp);
        }

        public ActionResult Delete(int id)
        {
            var emp = db.Contacts.Single(x => x.ContactId == id);// .Select(x => x.EmplyeeId == id).SingleOrDefault();

            return View(emp);

        }

        [HttpPost]
        public ActionResult Delete(int id, Contact contact)
        {
            try
            {

                contact.ContactId = id;

                db.Entry(contact).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

    }
}