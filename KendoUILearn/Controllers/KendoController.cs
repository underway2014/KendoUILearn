using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using KendoUILearn.Models;

namespace KendoUILearn.Controllers
{
    public class KendoController : Controller
    {
        private CustomDBContext db = new CustomDBContext();
        //
        // GET: /Kendo/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Students()
        {
            return View();

           // return Json(db.Students.ToList(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult StudentsData()
        {
            return Json(db.Students.ToList(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult Editor()
        {
            return View();
        }
        public ActionResult AddBlog()
        {
            return View();
        }
        public ActionResult BlogList()
        {
            return View(db.BlogS.ToList());
        }
	}
}