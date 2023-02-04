using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMaterialApp.Models;

namespace WebMaterialApp.ViewModels
{
    public class Vw_Mst_Admin_Routes
    {
        public Mst_AdminRoutes ParentRoute { get; set; }
        public List<Mst_AdminRoutes> ChildRoutes { get; set; }
    }
}