using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using KendoUILearn.Models;
using System.Web.Http.Cors;
using KendoUILearn.Helper;

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
        [HttpPost]
        public ActionResult AddBlog(string type,string title,string content,string time)
        {
            var res = -1;
            BlogModel md = new BlogModel
            {
                Type = type,
                Title = title,
                Content = Server.UrlDecode(content),
                AddTime = DateTime.Now.ToString()
            };
            db.BlogS.Add(md);
            res = db.SaveChanges();
            return Content(res.ToString()) ;
        }
        public ActionResult BlogList()
        {
            return View();
        }
        [EnableCors(origins: "http://localhost:4244/index.html", headers: "*", methods: "*")]
        public ActionResult BlogListData()
        {
            return Json(db.BlogS.ToList(), JsonRequestBehavior.AllowGet);
        }

        public JsonpResult GetData()
        {
            JsonpResult result = new JsonpResult(db.BlogS.ToList());
            return result;
        }
	}
}