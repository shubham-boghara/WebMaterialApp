using Antlr.Runtime.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMaterialApp.Commons
{
    public class AdminSessionTimeOut: ActionFilterAttribute, IActionFilter
    {
        void IActionFilter.OnActionExecuting(ActionExecutingContext filterContext)
        {
           var requestUrl = filterContext.HttpContext.Request.Url;
           var sessionUser = filterContext.HttpContext.Session["UserName"];
           var sessionRole = filterContext.HttpContext.Session["UserRole"];
           var urlHelper = new UrlHelper(filterContext.RequestContext);

            if (sessionUser == null)
            {
                if (filterContext.HttpContext.Request.IsAjaxRequest())
                {
                    filterContext.HttpContext.Response.Write($"<script>window.location.reload('{urlHelper.Content(System.IO.Path.Combine("AdminPortalLogin","Index"))}');</script>");
                }
                else
                {
                    if(requestUrl != null)
                    {
                        filterContext.Result = new RedirectResult($"/AdminPortalLogin/Index/?RedirectTo={requestUrl}");
                    }
                    else
                    {
                        filterContext.Result = new RedirectResult($"/AdminPortalLogin/Index");
                    }
                }
            }

           OnActionExecuting(filterContext);
        }
    }
}