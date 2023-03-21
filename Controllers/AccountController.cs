using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Merlin_web_Application.Models;
using Merlin_web_Application.ViewModel;



namespace Merlin_web_Application.Controllers
{
    public class AccountController : Controller
    {
        private Merlin_DataEntities db = new Merlin_DataEntities();


        
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Login user)
        {
            if (!ModelState.IsValid)
            { 
                return View("Login", user);
            }

            var pwd = Encryption.Encrypt(user.Password);

            var loginuser = db.User.Where(u => u.UserName == user.UserName && u.Password == pwd && u.Active == true).FirstOrDefault();
            if(loginuser==null)
            {
                ModelState.AddModelError("UserName", "UserName or Password is incorrect");
                
                return View("Login", user);
            }
            else
            {
                Session["UserName"] = loginuser.UserName;
                return RedirectToAction("Index", "Users");
            }
               
        }
        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Login");
        }
        
    }
}