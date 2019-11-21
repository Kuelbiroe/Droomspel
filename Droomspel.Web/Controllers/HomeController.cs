using Droomspel.data.Services;
using Droomspel.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Droomspel.Web.Controllers
{
    public class HomeController : Controller
    {
        IUserData db;

        public HomeController()
        {
            db = new UserData();
        }

        public ActionResult Index()
        {
            var model = new IndexViewModel();

            model.UserName = db.GetUserData("").Name; 

            return View(model);
        }

        public ActionResult AbcIndex()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult MathIndex()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult MessageIndex()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ProfileIndex()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult MusicIndex()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult GamesIndex()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}