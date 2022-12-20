using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LAB01_MVC5.Controllers
{
    public class MembersController : Controller
    {
        // GET: Members
        public ActionResult Create()
        {
            ViewBag.UserName = "Kiwi Hsieh";
            return View();
        }
    }
}