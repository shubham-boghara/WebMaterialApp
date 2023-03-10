using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMaterialApp.Commons;
using WebMaterialApp.Models;
using WebMaterialApp.ViewModels;

namespace WebMaterialApp.Controllers
{
    [AdminSessionTimeOut]
    public class AdminUsersController : Controller
    {
        WebModel DB = new WebModel();

       
        // GET: AdminUsers
        public ActionResult Index(int id = 0)
        {
            Vw_Admin_Users vw_Admin_Users = new Vw_Admin_Users();

            if (id > 0)
            {
                var Get_AdminUser = DB.Mst_WebAdmins.SingleOrDefault(m => m.Web_Admin_Id == id);
                if(Get_AdminUser != null)
                {
                    Get_AdminUser.Password = Helper.Decrypt(Get_AdminUser.Password);
                    vw_Admin_Users.AdminUser = Get_AdminUser;

                    
                    return View(vw_Admin_Users);
                }
                else
                {
                    return new HttpNotFoundResult();
                }
            }

            return View(vw_Admin_Users);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Vw_Admin_Users vw_Admin_Users)
        {
            try
            {
               /* if (ModelState.IsValid)
                {*/
                    if(vw_Admin_Users.AdminUser.Web_Admin_Id == 0)
                    {
                        vw_Admin_Users.AdminUser.Password = Helper.Encrypt(vw_Admin_Users.AdminUser.Password);
                        vw_Admin_Users.AdminUser.CreatedOn = DateTime.Now;
                        vw_Admin_Users.AdminUser.CreatedBy = int.Parse(Session["UserId"].ToString());
                        DB.Mst_WebAdmins.Add(vw_Admin_Users.AdminUser);
                        DB.SaveChanges();
                        TempData["AdminUsers"] = "User created successfully.";

                    }else if(vw_Admin_Users.AdminUser.Web_Admin_Id > 0)
                    {
                        var Get_AdminUser = DB.Mst_WebAdmins.SingleOrDefault(m => m.Web_Admin_Id == vw_Admin_Users.AdminUser.Web_Admin_Id);
                        if(Get_AdminUser != null)
                        {
                            Get_AdminUser.UserName = vw_Admin_Users.AdminUser.UserName;
                            Get_AdminUser.LastName = vw_Admin_Users.AdminUser.LastName;
                            Get_AdminUser.Email = vw_Admin_Users.AdminUser.Email;
                            Get_AdminUser.RoleId = vw_Admin_Users.AdminUser.RoleId;
                            Get_AdminUser.IsActive = vw_Admin_Users.AdminUser.IsActive;
                            Get_AdminUser.Password = Helper.Encrypt(vw_Admin_Users.AdminUser.Password);
                            Get_AdminUser.UpdatedOn = DateTime.Now;
                            Get_AdminUser.UpdatedBy = int.Parse(Session["UserId"].ToString());
                            DB.SaveChanges();

                            TempData["AdminUsers"] = "User updated successfully.";
                        }
                        else
                        {
                            TempData["AdminUsers"] = "User not found!";
                        }
                    }
                  
                    return RedirectToAction("Index", "AdminUsers");
               /* }*/
            }catch(Exception ex)
            {
                Helper.SaveException(ex, "AdminUsersController/Index");
                TempData["AdminUsers"] = "Server problem!";
            }

            return View(vw_Admin_Users);
        }

        public ActionResult Delete(int id)
        {
            try
            {
                var Admin_User = DB.Mst_WebAdmins.SingleOrDefault(m => m.Web_Admin_Id == id);
                if(Admin_User != null)
                {
                    Admin_User.DeletedOn = DateTime.Now;
                    Admin_User.DeletedBy = int.Parse(Session["UserId"].ToString());
                    DB.SaveChanges();

                    TempData["AdminUsers"] = "User delete successfully.";
                }
                else if(Admin_User == null)
                {
                    TempData["AdminUsers"] = "User not found!";
                }

            }
            catch(Exception ex)
            {
                Helper.SaveException(ex, "AdminUsersController/Delete");
                TempData["AdminUsers"] = "Server problem!";
            }

            return RedirectToAction("Index", "AdminUsers");
        }
        
    }
}