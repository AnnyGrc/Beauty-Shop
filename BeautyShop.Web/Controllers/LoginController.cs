using BeautyShop.BusinessLogic.Core;
using BeautyShop.BusinessLogic.Interfaces;
using BeautyShop.Models.Enteties.General;
using BeautyShop.Models.Enteties.User;
using BeautyShop.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BeautyShop.Web.Controllers
{
    public class LoginController : Controller
    {
        public readonly ISession _session;
        public readonly IMain _main;
        public LoginController()
        {
            var bl = new BusinessLogic.BusinessLogic();
            _session = bl.GetSessionBL();
            _main = bl.GetMainBL();
        }
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index(ULoginData data)
        {
            USessionData udata = new USessionData
            {
                UserName = data.UserName,
                UserPassword = data.UserPassword,
                SessionDate = DateTime.Now
            };

            _session.GetTest1();


            ResponseMsg st = _session.GetUserSession(udata);
            if (st.Status)
            {
                //COOKIES
            }
            else
            {
                string error = st.Error;

            }
            return View();
        }
    }
}