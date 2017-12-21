using Creational.SingleTon.Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Creational.SingleTon.Example.Controllers
{
    public class HomeController : Controller
    {
        private ILog _Ilog;

        public HomeController()
        {
            _Ilog = Log.GetInstance;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}