using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMaterialApp.Models;

namespace WebMaterialApp.ViewModels
{
    public class Vw_Admin_Users
    {
        WebModel Vw_DB = new WebModel();

        public Vw_Admin_Users()
        {
            UserList = Vw_DB.Mst_WebAdmins.Where(m => m.DeletedBy == null);
        }

        public IEnumerable<Mst_WebAdmins> UserList = null;
        public Mst_WebAdmins AdminUser { get; set; }
    }
}