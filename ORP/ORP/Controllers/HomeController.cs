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

        public ActionResult AllSubmissions()
        {
            ViewBag.Title = "AllSubmissions Page";

            return View();
        }

        public ActionResult MicrosoftAccountSubmissions()
        {
            ViewBag.Title = "MicrosoftAccountSubmissions Page";

            return View();
        }

        public ActionResult MySubmissions()
        {
            ViewBag.Title = "MySubmissions Page";

            return View();
        }

        public ActionResult NonMicrosoftSubmissions()
        {
            ViewBag.Title = "NonMicrosoftSubmissions Page";

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

        public ActionResult AllInterviewSchedules()
        {
            ViewBag.Title = "AllInterviewSchedules Page";

            return View();
        }

        public ActionResult OsloMicrosoftInterviewSchedules()
        {
            ViewBag.Title = "OsloMicrosoftInterviewSchedules Page";

            return View();
        }

        public ActionResult Zen3InterviewSchedules()
        {
            ViewBag.Title = "Zen3InterviewSchedules Page";

            return View();
        }

        public ActionResult BooleanSearch()
        {
            ViewBag.Title = "BooleanSearch Page";

            return View();
        }

        public ActionResult Reports()
        {
            ViewBag.Title = "Reports Page";

            return View();
        }

        public ActionResult RecruitmentTools()
        {
            ViewBag.Title = "RecruitmentTools Page";

            return View();
        }

        public ActionResult ClosedPositions()
        {
            ViewBag.Title = "ClosedPositions Page";

            return View();
        }

        public ActionResult AddClientManagerDetails()
        {
            ViewBag.Title = "AddClientManagerDetails Page";

            return View();
        }

        public ActionResult ViewClientManagerDetails()
        {
            ViewBag.Title = "ViewClientManagerDetails Page";

            return View();
        }
    }
}
