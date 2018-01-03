using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
namespace ilight
{
    public class SessionAuthorizeAttribute : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            return httpContext.Session["loggedin"] != null;
        }
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            filterContext.Controller.TempData["Type"] = "Danger";
            filterContext.Controller.TempData["Message"] = "Please login to access this page!";
            filterContext.Result = new RedirectResult("/account/login");
        }
    }

}
