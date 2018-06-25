using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ORP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult AddJob()
        {
            ViewBag.Title = "Add Job Page";

            return View();
        }

        public ActionResult AllPositions()
        {
            ViewBag.Title = "AllPositions Page";

            return View();
        }

        public ActionResult Submissions()
        {
            ViewBag.Title = "Submissions Page";

            return View();
        }

        public ActionResult InterviewSchedules()
        {
            ViewBag.Title = "InterviewSchedules Page";

            return View();
        }

        public ActionResult SearchAndReports()
        {
            ViewBag.Title = "SearchAndReports Page";

            return View();
        }

        public ActionResult ClientManagerDetails()
        {
            ViewBag.Title = "ClientManagerDetails Page";

            return View();
        }
    }
}
