using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BeautyShop.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
        public ActionResult DliaSalonov()
        {
            return View();
        }
        public ActionResult SignUp()
        {
            return View();
        }
        public ActionResult Uhod()
        {
            return View();
        }
        public ActionResult UhodMaski()
        {
            return View();
        }
        public ActionResult UhodDrugoe()
        {
            return View();
        }
        public ActionResult Lecenie()
        {
            return View();
        }
        public ActionResult LecenieMaski()
        {
            return View();
        }
        public ActionResult LecenieDrugoe()
        {
            return View();
        }
    }
}