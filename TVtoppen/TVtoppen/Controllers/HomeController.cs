using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TVtoppen.Models.db;
using TVtoppen.Security;

namespace TVtoppen.Controllers
{
    public class HomeController : Controller
    {
        private TVtoppenEntities db = new TVtoppenEntities();
        public ActionResult Index()
        {
            return View(db.Program.ToList());
        }

        [AuthorizeRoles("Admin")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [Authorize]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}