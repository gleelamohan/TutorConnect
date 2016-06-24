using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TutorConnectDataContracts;

namespace TutorConnect.Controllers
{
    public class TutorConnectHomeController : Controller
    {

        // GET: TutorConnectHome
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TutorProfile()
        {
            return View();
        }
    }
}