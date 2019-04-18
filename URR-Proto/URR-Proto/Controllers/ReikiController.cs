using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace URR_Proto.Controllers
{
    public class ReikiController : Controller
    {
        // GET: Reiki
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Historia()
        {
            return View();
        }
        public ActionResult Hautamuistomerkki()
        {
            return View();
        }

        public ActionResult Kaukoreiki()
        {
            return View();
        }
    }
}