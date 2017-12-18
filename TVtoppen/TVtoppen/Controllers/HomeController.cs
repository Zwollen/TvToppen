using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TVtoppen.Models.db;
using TVtoppen.Security;
using TVtoppen.Models;

namespace TVtoppen.Controllers
{
    public class HomeController : Controller
    {
        private TVtoppenEntities db = new TVtoppenEntities();
        public ActionResult Index()
        {
            var program = db.Program;

            ViewBag.newslist = db.News.ToList();
            return View(program.ToList());

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

        [HttpGet]
        public ActionResult chanlist()
        {
            ViewBag.addfavorite = db.Channel.Select(f => new SelectListItem { Value = f.Channel1.ToString(), Text = f.Channel1 });
            personchannels favorite = new personchannels();
            return View(favorite);
        }

        [HttpPost]
        public ActionResult personlist(personchannels favorite)
        {
            var Usr = Convert.ToInt32(Session["id"]);
            try
            {
                personchannels newfavorite = new personchannels();
                newfavorite.channelid = favorite.channelid;
                newfavorite.personid = Usr;
                db.personchannels.Add(newfavorite);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return RedirectToAction("MyPage", "Home");
        }
        public ActionResult addfavorite()
        {
            return View("chanlist");
        }
     
   
    }

}