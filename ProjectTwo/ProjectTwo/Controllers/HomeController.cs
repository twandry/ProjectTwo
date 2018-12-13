using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using ProjectTwo.DAL;
using ProjectTwo.Models;

namespace ProjectTwo.Controllers
{
    public class HomeController : Controller
    {
        private ProjectTwoContext db = new ProjectTwoContext();

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection form, bool rememberMe = false)
        {
            String email = form["userEmail"].ToString();
            String password = form["password"].ToString();

            var currentUser = db.Database.SqlQuery<Users>(
            "Select * " +
            "FROM Users " +
            "WHERE userEmail = '" + email + "' AND " +
            "password = '" + password + "'");

            if (currentUser.Count() > 0)
            {
                FormsAuthentication.SetAuthCookie(email, rememberMe);
                return RedirectToAction("Index", "MissionQuestions", new { userlogin = email });
            }
            else
            {
                return View();
            }
        }

        public ActionResult Index()
        {
            return View(db.Users.ToList());
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "userID,userFName,userLName,userEmail,password")] Users users, bool rememberMe = false)
        {
            if (ModelState.IsValid)
            {
                String email = "userEmail".ToString();
                db.Users.Add(users);
                db.SaveChanges();
                FormsAuthentication.SetAuthCookie(email, rememberMe);
                return RedirectToAction("Index");
            }

            return View(users);
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
