using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMaterialApp.Models;

namespace WebMaterialApp.ViewModels
{
    public class Vw_Admin_Users
    {
         WebModel DB = new WebModel();

        public Vw_Admin_Users()
        {
            UserList = DB.Vw_Mst_WebAdmins;
            RoleList = DB.Mst_Roles.Where(m => m.DeletedBy == null && m.IsActive == true)
                .Select(s => new SelectListItem { Text = s.RoleName, Value = s.RoleId.ToString() }).ToList();
        }


        public IQueryable<Vw_Mst_WebAdmins> UserList = null;
        public Mst_WebAdmins AdminUser { get; set; }

        public List<SelectListItem> RoleList = new List<SelectListItem>();
    }

}