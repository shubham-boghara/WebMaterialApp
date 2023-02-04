using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Mvc;
using WebMaterialApp.Models;
using WebMaterialApp.Commons;
using WebMaterialApp.ViewModels;

namespace WebMaterialApp.Controllers
{
    public class AdminPortalLoginController : Controller
    {
        WebModel DB = new WebModel();

        // GET: AdminPortalLogin
        public ActionResult Index(string RedirectTo)
        {
            try
            {
                ViewBag.RedirectTo = RedirectTo;
            }
            catch(Exception ex)
            {
                Helper.SaveException(ex, "AdminPortalLogin/Index");
            }
            return View(new Mst_WebAdmins());
        }

        [HttpPost]
        public ActionResult Index(Mst_WebAdmins mst_WebAdmins,string RedirectTo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string user_name = mst_WebAdmins.UserName;
                    string password = mst_WebAdmins.Password;

                    if(!string.IsNullOrEmpty(user_name) && !string.IsNullOrEmpty(password))
                    {
                        var encrypt_str = Helper.Encrypt(mst_WebAdmins.Password);
                        var decrypt_str = Helper.Decrypt(encrypt_str);

                        var get_user = DB.Mst_WebAdmins.SingleOrDefault(m => m.UserName == user_name && m.Password == encrypt_str && m.IsActive == true);

                        if (get_user != null)
                        {
                            var get_user_role = DB.Mst_Roles.Where(r => r.RoleId == get_user.RoleId).Select(r => r.RoleName).FirstOrDefault();
                            Session["UserName"] = get_user.UserName;
                            Session["RoleName"] = get_user_role;
                            Session["UserId"] = get_user.Web_Admin_Id;

                            List<Vw_Mst_Admin_Routes> vw_Mst_Admin_Routes_List = new List<Vw_Mst_Admin_Routes>();

                            var get_parent_routes = (from routs in DB.Mst_AdminRouts
                                                     where routs.DeletedBy == null && routs.IsActive == true && routs.ParentRouteId == 0
                                                     orderby routs.SortOdr
                                                     select routs).ToList();

                            if(get_parent_routes != null && get_parent_routes.Any())
                            {
                                foreach(var parent_route in get_parent_routes)
                                {
                                    var chile_routes = (from routs in DB.Mst_AdminRouts
                                                        where routs.DeletedBy == null && routs.IsActive == true && routs.ParentRouteId == parent_route.RouteId
                                                        orderby routs.SortOdr
                                                        select routs).ToList();

                                    vw_Mst_Admin_Routes_List.Add(new Vw_Mst_Admin_Routes { ParentRoute = parent_route,ChildRoutes = chile_routes });
                                }
                            }

                            TempData["Routes"] = vw_Mst_Admin_Routes_List;
                            TempData.Keep("Routes");

                            if (!string.IsNullOrEmpty(RedirectTo))
                            {
                                return Redirect(RedirectTo);
                            }
                            else
                            {
                                return RedirectToAction("Index", "AdminPortal");
                            }
                        }

                        else
                        {
                            ModelState.AddModelError("model_error", "Invalid UserName and Password");
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("model_error", "Invalid UserName and Password");
                    }
                }

            }catch(Exception ex)
            {
                Helper.SaveException(ex, "AdminPortalLogin/Index");
            }

            ViewBag.RedirectTo = RedirectTo;
            return View(mst_WebAdmins);
        }

        public ActionResult LogOff()
        {
            try
            {
                Session["UserName"] = null;
                Session["RoleName"] = null;
                Session.Remove("UserName");
                Session.Remove("RoleName");
            }
            catch(Exception ex)
            {
                Helper.SaveException(ex, "AdminPortalLogin/LogOff");
            }

            return RedirectToAction("Index", "AdminPortalLogin");
        }
    }
}