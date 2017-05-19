using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using git_test.Models;

namespace git_test.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        //Register
        public ActionResult Register(UserAccount account)
        {
           if(ModelState.IsValid)
            {
                using (OurDbContex db = new OurDbContex())
                {
                    //db.userAccount.Add(account);
                    db.SaveChanges();

                    ModelState.Clear();
                    ViewBag.Message = account.FirstName + " " + account.LastName + " konto zostało zarejestrowane";
                }
            }
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserAccount user)
        { using (OurDbContex db = new OurDbContex())
          {
                var usr = db.userAccount.Where(u => u.Username == user.Username && u.Password == user.Password).FirstOrDefault();
        //        if (usr != null)
        //        {
                    Session["UserId"] = usr.UserId.ToString();
                    Session["Username"] = usr.Username.ToString();
                    return RedirectToAction("LoggedIn");
        //        }
        //        else
        //        {
        //            ModelState.AddModelError("", "Nieprawidłowe hasło lub login");
        //        }
           }
            return View();
               
        }


        public ActionResult LoggedIn()
        {
            if(Session["UserId"]!=null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Login");
        }

        public ActionResult Chat(UserAccount user)
        {
            int user_id = user.UserId;
            Message msg = new Message();
            

            return ViewBag;
        }
    }
}