using PalAdvisor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PalAdvisor.Controllers
{
    public class DetailController : Controller
    {
        // GET: Detail
        public ActionResult Index(int destinationId)
        {
            PalAdviserDBEntities db = new PalAdviserDBEntities();

            //evaluate
            CraneEvaluator evaluator = new CraneEvaluator();
            evaluator.cranes = db.Crane.ToList();
            var evaluatedCranes = evaluator.EvaluateDestination(db.Destination.First(i => i.Id == destinationId));

            // properCranes
            return View(evaluatedCranes);
        }
    }
}