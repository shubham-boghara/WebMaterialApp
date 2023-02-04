using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMaterialApp.Commons;


namespace WebMaterialApp.Controllers
{
    [AdminSessionTimeOut]
    public class AdminPortalController : Controller
    {
        // GET: AdminPortal
        public ActionResult Index()
        {
            return View();
        }
    }
}