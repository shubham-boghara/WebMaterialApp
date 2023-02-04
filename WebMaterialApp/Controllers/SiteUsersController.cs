using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMaterialApp.Controllers { 
    public class SiteUsersController : Controller
    {
        // GET: SiteUsers
        public ActionResult Index()
        {
            return View();
        }
    }
}