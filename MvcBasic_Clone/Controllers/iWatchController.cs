using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBasic_Clone.Controllers
{
    public class iWatchController : Controller
    {
        // GET: iWatch
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult iWatchPage()
        {
            return View();
        }
    }
}