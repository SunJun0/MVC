using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopMVC.Filter
{
    public class LoginFilter:AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            if (filterContext.HttpContext.Session["employee"] == null)
            {
                filterContext.Result = new RedirectResult("/Account/Login");
            }
        }
    }
}