using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TVtoppen.Data;
using TVtoppen.Models.db;
using TVtoppen.Models.ViewModels;

namespace TVtoppen.Controllers
{
    public class AccountController : Controller
    {        
       private dbOperations db = new dbOperations();
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginVM model, string ReturnUrl)
        {
            if (ModelState.IsValid)
            {

                if (db.CheckUserCredentials(model.Username, model.Password))
                {
                FormsAuthentication.SetAuthCookie(model.Username, false);
                return Redirect(ReturnUrl);
                }
                else
                {
                    ModelState.AddModelError("", "Felaktigt användarnamn eller lösenord.");                    
                }
            }
            return View();
        }

        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}