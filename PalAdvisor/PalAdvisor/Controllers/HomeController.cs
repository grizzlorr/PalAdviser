using PalAdvisor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PalAdvisor.Controllers
{

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            PalAdviserDBEntities db = new PalAdviserDBEntities();
            return View(db.Destination.ToList());
        }
    }
}